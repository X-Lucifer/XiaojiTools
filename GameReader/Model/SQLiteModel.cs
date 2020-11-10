using Microsoft.EntityFrameworkCore;

namespace GameReader.Model
{
    public class SQLiteModel : DbContext
    {
        public SQLiteModel(DbContextOptions<SQLiteModel> options) : base(options)
        {
            
        }

        public SQLiteModel()
        {
            
        }

        public virtual DbSet<DownloadInfo> DownloadInfos { get; set; }

        public virtual DbSet<EmulatorInfo> EmulatorInfos { get; set; }

        public virtual DbSet<Gameinfo> Gameinfos { get; set; }

        public virtual DbSet<LocalGame> Localgames { get; set; }
    }
}