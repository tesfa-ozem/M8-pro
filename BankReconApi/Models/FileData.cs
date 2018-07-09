using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BankReconApi.Models
{
    public class FileData

    {
        [Key]
        public long ID { get; set; }
       
        public long FileId { get; set; }
        [StringLength(50)]
        public string Col1 { get; set; }
        [StringLength(50)]
        public string Col2 { get; set; }
        [StringLength(50)]
        public string Col3 { get; set; }
        [StringLength(50)]
        public string Col4 { get; set; }
        [StringLength(50)]
        public string Col5 { get; set; }
        [StringLength(50)]
        public string Col6 { get; set; }
        [StringLength(50)]
        public string Col7 { get; set; }
        [StringLength(50)]
        public string Col8 { get; set; }
        [StringLength(50)]
        public string Col9 { get; set; }
        [StringLength(50)]
        public string Col10 { get; set; }
        [StringLength(50)]
        public string Col11 { get; set; }
        [StringLength(50)]
        public string Col12 { get; set; }
        [StringLength(50)]
        public string Col13 { get; set; }
        [StringLength(50)]
        public string Col14 { get; set; }
        [StringLength(50)]
        public string Col15 { get; set; }
        [StringLength(50)]
        public string Col16 { get; set; }
        [StringLength(50)]
        public string Col17 { get; set; }
        [StringLength(50)]
        public string Col18 { get; set; }
        [StringLength(50)]
        public string Col19 { get; set; }
        [StringLength(50)]
        public string Col20 { get; set; }
        [StringLength(50)]
        [ForeignKey("FileId")] public virtual FileType FileType { get; set; }
    }
}