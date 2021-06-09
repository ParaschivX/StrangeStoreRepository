namespace Infrastructure
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        void SaveChangesAsync();

    }
}
