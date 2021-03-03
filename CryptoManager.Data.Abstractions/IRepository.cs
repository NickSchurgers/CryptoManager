namespace CryptoManager.Data
{
    public interface IRepository
    {
    }

    public interface IRepository<TModel> : IRepository
        where TModel : IModel
    {
    }
}
