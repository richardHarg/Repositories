using RLH.QueryParameters.Entities;
using RLH.QueryParameters.Interfaces;


namespace RLH.Repositories
{
    /// <summary>
    /// Interface exposing Get operations for collections of type T
    /// </summary>
    /// <typeparam name="T">Base type to query</typeparam>
    public interface ICollectionRepository<T>
    {
        public Task<IEnumerable<T>> GetAsync(PaginationParameters paginationParameters,IQueryParameters queryParameters);
        public Task<int> CountAsync(IQueryParameters queryParameters);
    }
}
