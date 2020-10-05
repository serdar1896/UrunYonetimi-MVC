using Product.Data.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;
namespace Product.Data.DataContext
{
    class DbContextConfiguration : DbConfiguration
    {
        public DbContextConfiguration()
        {
            this.SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
        }
    }

    [DbConfigurationType(typeof(DbContextConfiguration))]
    public class ProductContext:DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductFeature> ProductFeature { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }

        //Table oluşturulurken çoğul adla değilde benim verdiğim tekil isimle oluşsun
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
