using RLH.QueryParameters.Entities;
using RLH.QueryParameters.Interfaces;

namespace RLH.Repositories
{
    /// <summary>
    /// Interface exposing Get/Exists operations using a name to identify the type of T
    /// </summary>
    /// <typeparam name="T">Base type to query</typeparam>
    public interface IByNameRepository<T>
    {
        public Task<T> GetByNameAsync(string name);
        public Task<bool> ExistsByNameAsync(string name);

    }
}
