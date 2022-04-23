using User_Interface_1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Nuke.Common.ChangeLog;

namespace User_Interface_1.Data
{
    public class UIDbContext :DbContext
    {
        public UIDbContext(DbContextOptions<UIDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public override int SaveChanges()
        {
            try
            {
                // Değişen Var mı? Boya Var mı :)            
                var modifiedEntities = ChangeTracker.Entries()
                   .Where(p => p.State == EntityState.Modified).ToList();
                var now = System.DateTime.UtcNow;
                foreach (var change in modifiedEntities)
                {
                    var entityName = change.Entity.GetType().Name;

                    var PrimaryKey = change.OriginalValues.Properties.FirstOrDefault(prop => prop.IsPrimaryKey() == true).Name;

                    foreach (IProperty prop in change.OriginalValues.Properties)
                    {

                        var originalValue = change.OriginalValues[prop.Name].ToString();
                        var currentValue = change.CurrentValues[prop.Name].ToString();

                        
                    }

                }
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return 0;
            }
        }
    }
}



