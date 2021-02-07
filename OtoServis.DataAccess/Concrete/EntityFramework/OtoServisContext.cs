using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using OtoServis.Entities.Concrete;

namespace OtoServis.DataAccess.Concrete.EntityFramework
{
    public class OtoServisContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-9I5CLL9;Database=Tamirhane;Trusted_Connection=True;MultipleActiveResultSets=true");

        }


        //    public OtoServisContext(DbContextOptions<OtoServisContext> options)
        //: base(options)
        //    { }

        public DbSet<ServiceOperation> ServiceOperations { get; set; }
        public DbSet<User>Users { get; set; }
    }
}
