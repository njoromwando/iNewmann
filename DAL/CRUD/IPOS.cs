using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.POS;

namespace DAL.CRUD
{
    public interface IPOS
    {
        Task CreateProducts(object[] args);
        Task<IEnumerable<Product>> ProductDetails(object[] args);
        Task UpdateProducts(object[] args);
    }
}