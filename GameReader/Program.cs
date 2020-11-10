using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GameReader.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameReader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                Console.WriteLine("数据初始化...");
                IServiceCollection service = new ServiceCollection();
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(AppContext.BaseDirectory))
                    .AddJsonFile("appconfig.json");
                var config = builder.Build();
                var dbcon = config["SQLite"] ?? "";
                if (string.IsNullOrEmpty(dbcon))
                {
                    Console.Beep();
                    Console.WriteLine("出现异常: 请在配置文件'appconfig.json'的'SQLite'节点中指定游戏数据库文件路径!");
                    Console.ReadLine();
                    return;
                }
                var savepath = config["SavePath"] ?? "";
                if (string.IsNullOrEmpty(savepath))
                {
                    savepath = AppContext.BaseDirectory + "Game";
                }

                if (!Directory.Exists(savepath))
                {
                    Directory.CreateDirectory(savepath);
                }

                if (!savepath.EndsWith(@"\"))
                {
                    savepath = savepath + @"\";
                }
                service.AddDbContext<SQLiteModel>(x => { x.UseSqlite(dbcon); }, ServiceLifetime.Transient);
                var provider = service.BuildServiceProvider();
                var db = provider.GetService<SQLiteModel>();
                Console.WriteLine("数据库加载成功!");
                var list = await db.Gameinfos.OrderBy(x=>x.EmulatorShortName).ToListAsync();
                Console.WriteLine("游戏数据加载成功!");
                Console.WriteLine();
                foreach (var item in list)
                {
                    string file = item.FilePath + item.FileName;
                    if (!File.Exists(file) || item.EmulatorShortName.Equals("PC"))
                    {
                        continue;
                    }

                    string basedir = savepath + item.EmulatorShortName + @"\";
                    if (!Directory.Exists(basedir))
                    {
                        Directory.CreateDirectory(basedir);
                    }
                    FileInfo info = new FileInfo(file);
                    string xname = item.GameName + info.Extension;
                    if (item.EmulatorShortName.Equals("MAME") || item.EmulatorShortName.Equals("MAMEPlus") || item.EmulatorShortName.Equals("ARCADE"))
                    {
                        xname = item.FileName;
                    }
                    File.Copy(file, basedir + xname, true);
                    Console.WriteLine($"游戏:【{item.GameName}】, 类型:【{item.EmulatorShortName}】已生成!");
                }

                Console.WriteLine();
                Console.WriteLine("生成成功 , 按任意键退出程序!");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"出现异常: {e}");
                Console.ReadLine();
            }
        }
    }
}