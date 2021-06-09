using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using System.Linq;


namespace Infrastructure
{


    //public interface IEntityTypeConfigurationRegistrar
    //{
    //    void ApplyConfiguration(ModelBuilder modelBuilder);
    //}
    public class DataContext : IdentityDbContext<ApplicationUser>, IDataRepository, IUnitOfWork
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<Item2> Items2 { get; set; }

        public DbSet<Message> Messages { get; set; }



        public IQueryable<TEntity> Query<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }

        void IDataRepository.Add<TEntity>(TEntity entity)
        {
            this.Add(entity);


        }

        void IDataRepository.Remove<TEntity>(TEntity entity)
        {
            this.Remove<TEntity>(entity);
        }
        void IDataRepository.Update<TEntity>(TEntity entity)
        {
            this.Update<TEntity>(entity);
        }
        void IUnitOfWork.SaveChanges()
        {
            SaveChanges();
        }

        public void SaveChangesAsync()
        {
            SaveChangesAsync();
        }




        //  public DbSet<Client> Clients { get; set; }

    }
}

