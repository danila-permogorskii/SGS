using System.Collections.Generic;
using Infrastructure.DataAcess.CRUDInterfaces;
using ParceData;

namespace Infrastructure.DataAcess
{
    public interface IValuteRepository : ICanUpdateEntity<Valute>, ICanAddEntity<Valute>, ICanGetEntity<Valute>
    {
        
    }
}