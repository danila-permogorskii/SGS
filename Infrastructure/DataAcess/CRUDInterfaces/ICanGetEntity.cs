using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.DataAcess.CRUDInterfaces
{
    public interface ICanGetEntity<TEntity> where TEntity : class
    {
        public void Get(TEntity entity);
    }
}