using System.Collections.Generic;

namespace Infrastructure.DataAcess.CRUDInterfaces
{
    public interface ICanAddList<TEntity> where TEntity : class
    {
        public void AddList(List<TEntity> entities);
    }
}