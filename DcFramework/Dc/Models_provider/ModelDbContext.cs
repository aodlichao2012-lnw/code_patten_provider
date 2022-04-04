using datacenter;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacenter
{
    public class ModelDbContext : DbContext
    {
        public ModelDbContext () : base("Dbcontects")
        {

        }
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            
        }
        public DbSet<ModelViewModels> modelViewModels { get; set; }
    }
}
