
using Business.Interfaces;
using Business.Models;
using FirstRestAPI.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
{
    public readonly ApiDbContext Db;
    public readonly DbSet<TEntity> DbSet;
    public Repository(ApiDbContext context)
    {
        Db = context;
        DbSet = Db.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> predicate)
    {
        return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
    }

    public virtual async Task<TEntity?> Get(Guid id)
    {
        return await DbSet.FirstOrDefaultAsync(t => t.Id == id);
    }

    public virtual async Task<List<TEntity>> Get()
    {
        return await DbSet.ToListAsync();
    }

    public virtual async Task Add(TEntity entity)
    {
        DbSet.Add(entity);
        await SaveChanges();
    }

    public async Task<int> SaveChanges()
    {
        return await Db.SaveChangesAsync();
    }
    public virtual async Task Update(TEntity entity)
    {
        DbSet.Update(entity);
        await SaveChanges();
    }

    public virtual async Task Remove(Guid id)
    {
        DbSet.Remove(new TEntity{Id = id});
        await SaveChanges();
    }
    public void Dispose()
    {
        Db?.Dispose();
    }
}
