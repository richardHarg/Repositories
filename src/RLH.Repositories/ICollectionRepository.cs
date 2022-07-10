using RLH.QueryParameters.Core.Entities;


namespace RLH.Repositories
{
    /// <summary>
    /// Interface exposing Get operations for collections of type T
    /// </summary>
    /// <typeparam name="T">Base type to query</typeparam>
    public interface ICollectionRepository<T>
    {
        public Task<IEnumerable<T>> GetAsync(IPaginationParameters paginationParameters,IQueryingParameters queryParameters);
        public Task<int> CountAsync(IQueryingParameters queryParameters);
    }
}
