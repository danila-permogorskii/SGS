using System.Collections.Generic;
using System.Linq;
using Entities.JsonDataClasses;

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
        

        public void Get(Valute entity)
        {
            throw new System.NotImplementedException();
        }

        // public IReadOnlyList<Valute> GetAll()
        // {
        //     return _dbContext.Valutes.Where(v => v.NumCode).ToList();
        // }
    }
}