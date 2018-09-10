namespace TeduShop.Data.Infrastructure
{
    // thiết kế phương thức commit
    public interface IUnitOfWork
    {
        void Commit();
    }
}