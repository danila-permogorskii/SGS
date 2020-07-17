namespace Infrastructure.DataAcess.CRUDInterfaces
{
    public interface ICanDeleteEntity<TEntity> where TEntity : class
    {
        public void Remove(TEntity entity);
    }
}