namespace Infrastructure.DataAcess.CRUDInterfaces
{
    public interface ICanAddEntity<TEntity> where TEntity : class
    {
        public void Add(TEntity entity);
    }
}