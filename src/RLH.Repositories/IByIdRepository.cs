using RLH.QueryParameters.Entities;
using RLH.QueryParameters.Interfaces;

namespace RLH.Repositories
{
    /// <summary>
    /// Interface exposing Get/Exists operations using an Id to identify the type of T
    /// </summary>
    /// <typeparam name="T">Base type to query</typeparam>
    public interface IByIdRepository<T>
    {
        public Task<T> GetByIdAsync(string id);
        public Task<bool> ExistsByIdAsync(string id);

    }
}
