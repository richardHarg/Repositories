using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLH.Repositories
{
    public interface IDynamicPaginatedCollectionRepository<T>
    {
        public Task<IEnumerable<T>> GetAsync(int pageSize,int pageNumber,string dynamicWhere,string dynamicOrderBy);
        public Task<int> CountAsync(string dynamicWhere, string dynamicOrderBy);
    }
}
