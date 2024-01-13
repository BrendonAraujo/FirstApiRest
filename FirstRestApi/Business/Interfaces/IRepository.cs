using Business.Models;
using System.Linq.Expressions;

namespace Business.Interfaces;

public interface IRepository<TEntity> where TEntity : Entity, new()
{
    Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> predicate);
    Task<List<TEntity>> Get();
    Task<TEntity?> Get(Guid id);
    Task Add(TEntity entity);
    Task<int> SaveChanges();
    Task Update(TEntity entity);
    Task Remove(Guid id);
    void Dispose();
}
