using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BankReconApi.Models
{
    public class BankReconApiContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BankReconApiContext() : base("name=BankReconApiContext")
        {
        }

        public System.Data.Entity.DbSet<BankReconApi.Models.FileType> FileTypes { get; set; }

        public System.Data.Entity.DbSet<BankReconApi.Models.FileData> FileDatas { get; set; }
                
        public System.Data.Entity.DbSet<BankReconApi.Models.RegisterBindingModel> GetRegisterBindingModels { get; set; }

        public System.Data.Entity.DbSet<BankReconApi.Models.UserLoginInfoViewModel> LoginInfoViewModels { get; set; }



    }
}
