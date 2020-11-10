using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReader.Model
{
    [Table("Gameinfo")]
    public partial class Gameinfo
    {
    
        /// <summary>
        /// get or set Id
        /// </summary>
        [Key]
        public Int64 Id { get; set; }
    
        /// <summary>
        /// get or set GameId
        /// </summary>
        public String GameId { get; set; }
    
        /// <summary>
        /// get or set Icon
        /// </summary>
        public String Icon { get; set; }
    
        /// <summary>
        /// get or set Size
        /// </summary>
        public String Size { get; set; }
    
        /// <summary>
        /// get or set GameName
        /// </summary>
        public String GameName { get; set; }
    
        /// <summary>
        /// get or set EmulatorShortName
        /// </summary>
        public String EmulatorShortName { get; set; }
    
        /// <summary>
        /// get or set CategoryShortName
        /// </summary>
        public String CategoryShortName { get; set; }
    
        /// <summary>
        /// get or set IsPlay
        /// </summary>
        public String IsPlay { get; set; }
    
        /// <summary>
        /// get or set IsPK
        /// </summary>
        public String IsPK { get; set; }
    
        /// <summary>
        /// get or set FilePath
        /// </summary>
        public String FilePath { get; set; }
    
        /// <summary>
        /// get or set FileName
        /// </summary>
        public String FileName { get; set; }
    
        /// <summary>
        /// get or set EmulatorId
        /// </summary>
        public String EmulatorId { get; set; }
    
        /// <summary>
        /// get or set CategoryId
        /// </summary>
        public String CategoryId { get; set; }
    
        /// <summary>
        /// get or set PlayUrl
        /// </summary>
        public String PlayUrl { get; set; }
    
        /// <summary>
        /// get or set DbVer
        /// </summary>
        public String DbVer { get; set; }
    }
}
