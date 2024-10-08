using System.Linq.Expressions;
using SqlSugar;
using Tally.IRepository;
using Tally.IService;

namespace Tally.Service;

public class BaseService<TEntity>(IBaseRepository<TEntity> repository) : IBaseService<TEntity>
    where TEntity : class, new()
{
    /// <summary>
    ///     让子类从构造函数中传入
    /// </summary>
    private readonly IBaseRepository<TEntity> _repository = repository;

    public async Task<bool> CreatAsync(TEntity entity)
    {
        return await _repository.CreatAsync(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _repository.DeleteAsync(id);
    }

    public async Task<bool> EditAsync(TEntity entity)
    {
        return await _repository.EditAsync(entity);
    }

    public async Task<TEntity> FindAsync(int id)
    {
        return await _repository.FindAsync(id);
    }

    public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> func)
    {
        return await _repository.FindAsync(func);
    }

    public virtual async Task<List<TEntity>> QueryAsync()
    {
        return await _repository.QueryAsync();
    }

    public virtual async Task<List<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> func)
    {
        return await _repository.QueryAsync(func);
    }

    public virtual async Task<List<TEntity>> QueryAsync(int page, int pageSize, RefAsync<int> total)
    {
        return await _repository.QueryAsync(page, pageSize, total);
    }

    public virtual async Task<List<TEntity>> QueryAsync(
        Expression<Func<TEntity, bool>> func,
        int page,
        int pageSize,
        RefAsync<int> total
    )
    {
        return await _repository.QueryAsync(func, page, pageSize, total);
    }
}