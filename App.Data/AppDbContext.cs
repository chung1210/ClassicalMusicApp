using App.Model.Abstract;
using App.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }


        public DbSet<BaiHat> BaiHats { set; get; }
        public DbSet<CaSi> CaSies { set; get; }
        public DbSet<Album> Albums { set; get; }



        public static AppDbContext Create()
        {
            return new AppDbContext();
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (DbEntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IAuditable;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        changedOrAddedItem.CreatedDate = DateTime.Now;
                    }
                    changedOrAddedItem.UpdatedDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("ApplicationUserRoles");
            //builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("ApplicationUserLogins");
            //builder.Entity<IdentityRole>().ToTable("ApplicationRoles");
            //builder.Entity<IdentityUserClaim>().HasKey(i => i.UserId).ToTable("ApplicationUserClaims");

        }
    }
}
