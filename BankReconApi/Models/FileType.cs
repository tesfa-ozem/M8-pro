using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankReconApi.Models
{
    public class FileType
    {
        [Key]
        public long FileId { get; set; }

        public string FileName { get; set; }
        
    }
}