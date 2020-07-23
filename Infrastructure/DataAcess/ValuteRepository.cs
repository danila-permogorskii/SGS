using System.Collections.Generic;
using System.Linq;
using Entities.JsonDataClasses;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataAcess
{
    public class ValuteRepository : AuditableRepository<Valute>, IValuteRepository
    {
        private readonly AppDbContext _dbContext;
        
        public ValuteRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        

        public IReadOnlyList<Valute> GetValuteByCharCode(string code)
        {
            return _dbContext.Valutes.Where(v => v.CharCode.ToLower().Contains(code.ToLower())).ToList();
        }
        

        public Valute Get(Valute entity)
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyList<Valute> GetAll()
        {
            return _dbContext.Valutes.ToList();
        }

        public IReadOnlyList<Valute> GetValuteById(string id)
        {
            return _dbContext.Valutes.Where(v => v.ID.ToLower().Contains(id.ToLower())).ToList();
        }
    }
}