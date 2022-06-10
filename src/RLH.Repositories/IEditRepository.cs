using RLH.Result;

namespace RLH.Repositories
{
    /// <summary>
    /// Interface exposing methods to create/delete/update a entity of type T
    /// </summary>
    /// <typeparam name="T">Base type to query</typeparam>
    public interface IEditRepository<T>
    {
        public Task<T> CreateAsync(T entity);
        public Task<ResultOf<T>> UpdateAsync(T entity);
        public Task<bool> DeleteAsync(T entity);


    }
}
