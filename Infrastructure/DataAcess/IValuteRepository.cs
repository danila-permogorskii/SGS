using System.Collections.Generic;
using Entities.JsonDataClasses;
using Infrastructure.DataAcess.CRUDInterfaces;

namespace Infrastructure.DataAcess
{
    public interface IValuteRepository : ICanUpdateEntity<Valute>, ICanAddEntity<Valute>, ICanGetEntity<Valute>, ICanAddList<Valute>
    {
        IReadOnlyList<Valute> GetAll();
        IReadOnlyList<Valute> GetValuteById(string id);
    }
}