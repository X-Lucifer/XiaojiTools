using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReader.Model
{
    [Table("DownloadInfo")]
    public partial class DownloadInfo
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
        /// get or set FilePath
        /// </summary>
        public String FilePath { get; set; }
    
        /// <summary>
        /// get or set FileName
        /// </summary>
        public String FileName { get; set; }
    
        /// <summary>
        /// get or set NeedUnZip
        /// </summary>
        public String NeedUnZip { get; set; }
    
        /// <summary>
        /// get or set Volume
        /// </summary>
        public String Volume { get; set; }
    
        /// <summary>
        /// get or set UrlList
        /// </summary>
        public String UrlList { get; set; }
    
        /// <summary>
        /// get or set PanUrlList
        /// </summary>
        public String PanUrlList { get; set; }
    
        /// <summary>
        /// get or set PanRealUrlList
        /// </summary>
        public String PanRealUrlList { get; set; }
    
        /// <summary>
        /// get or set VolumeUrlList
        /// </summary>
        public String VolumeUrlList { get; set; }
    
        /// <summary>
        /// get or set VolumePanUrlList
        /// </summary>
        public String VolumePanUrlList { get; set; }
    
        /// <summary>
        /// get or set VolumePanRealUrlList
        /// </summary>
        public String VolumePanRealUrlList { get; set; }
    
        /// <summary>
        /// get or set FileLenth
        /// </summary>
        public String FileLenth { get; set; }
    
        /// <summary>
        /// get or set VolumeFileLenth
        /// </summary>
        public String VolumeFileLenth { get; set; }
    
        /// <summary>
        /// get or set FileList
        /// </summary>
        public String FileList { get; set; }
    
        /// <summary>
        /// get or set TotalSize
        /// </summary>
        public String TotalSize { get; set; }
    
        /// <summary>
        /// get or set CurrentSize
        /// </summary>
        public String CurrentSize { get; set; }
    
        /// <summary>
        /// get or set Reserved1
        /// </summary>
        public String Reserved1 { get; set; }
    
        /// <summary>
        /// get or set Reserved2
        /// </summary>
        public String Reserved2 { get; set; }
    
        /// <summary>
        /// get or set Reserved3
        /// </summary>
        public String Reserved3 { get; set; }
    
        /// <summary>
        /// get or set Reserved4
        /// </summary>
        public String Reserved4 { get; set; }
    
        /// <summary>
        /// get or set DbVer
        /// </summary>
        public String DbVer { get; set; }
    }
}
