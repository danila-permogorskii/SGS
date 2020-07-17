using System;
using System.Net.Mime;
using Entities;

namespace Infrastructure.DataAcess
{
    public abstract class AuditableRepository<TEntity> : Repository<TEntity>
    where TEntity : AuditableEntity
    {
        protected AuditableRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override void Add(TEntity entity)
        {
            entity.CreatedAt = DateTime.Now;
            base.Add(entity);
            SaveChanges();
        }

        public override void Update(TEntity entity)
        {
            entity.ModifiedAt = DateTime.Now;
            base.Update(entity);
            SaveChanges();
        }
    }
}