namespace RepositoryPtrn.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entity);
        void Delete(int id);
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}
