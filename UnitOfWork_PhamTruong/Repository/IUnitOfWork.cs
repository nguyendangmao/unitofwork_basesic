namespace UnitOfWork_PhamTruong.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }

        int Save();
    }
}
