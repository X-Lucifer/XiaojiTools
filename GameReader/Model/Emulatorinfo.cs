using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReader.Model
{
    [Table("EmulatorInfo")]
    public partial class EmulatorInfo
    {
    
        /// <summary>
        /// get or set Id
        /// </summary>
        [Key]
        public Int64 Id { get; set; }
    
        /// <summary>
        /// get or set EmulatorId
        /// </summary>
        public String EmulatorId { get; set; }
    
        /// <summary>
        /// get or set Name
        /// </summary>
        public String Name { get; set; }
    
        /// <summary>
        /// get or set Version
        /// </summary>
        public String Version { get; set; }
    
        /// <summary>
        /// get or set Downloadurl
        /// </summary>
        public String Downloadurl { get; set; }
    
        /// <summary>
        /// get or set UpdateDate
        /// </summary>
        public String UpdateDate { get; set; }
    
        /// <summary>
        /// get or set Description
        /// </summary>
        public String Description { get; set; }
    
        /// <summary>
        /// get or set Emulatortype
        /// </summary>
        public String Emulatortype { get; set; }
    
        /// <summary>
        /// get or set System
        /// </summary>
        public String System { get; set; }
    
        /// <summary>
        /// get or set Executet
        /// </summary>
        public String Executet { get; set; }
    
        /// <summary>
        /// get or set Executeparam
        /// </summary>
        public String Executeparam { get; set; }
    
        /// <summary>
        /// get or set Configtype
        /// </summary>
        public String Configtype { get; set; }
    
        /// <summary>
        /// get or set KeyConfig
        /// </summary>
        public String KeyConfig { get; set; }
    
        /// <summary>
        /// get or set SetConfig
        /// </summary>
        public String SetConfig { get; set; }
    
        /// <summary>
        /// get or set IsDefault
        /// </summary>
        public String IsDefault { get; set; }
    
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
        /// get or set Reserved5
        /// </summary>
        public String Reserved5 { get; set; }
    
        /// <summary>
        /// get or set Reserved6
        /// </summary>
        public String Reserved6 { get; set; }
    
        /// <summary>
        /// get or set Reserved7
        /// </summary>
        public String Reserved7 { get; set; }
    
        /// <summary>
        /// get or set Reserved8
        /// </summary>
        public String Reserved8 { get; set; }
    
        /// <summary>
        /// get or set DbVer
        /// </summary>
        public String DbVer { get; set; }
    }
}
