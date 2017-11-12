using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Web;
using DigitalCanteen.Models;

namespace DigitalCanteen.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
            : base("DataContext")
        {
            Database.SetInitializer<DataContext>(new CreateDatabaseIfNotExists<DataContext>());
        }
        public  DbSet<UserCredential> UserCredentials { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
   
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}