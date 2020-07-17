namespace Infrastructure.DataAcess.CRUDInterfaces
{
    public interface ICanUpdateEntity<TEntity> where TEntity : class
    {
        public void Update(TEntity entity);
    }
}