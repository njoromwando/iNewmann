using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.POS;

namespace DAL.CRUD
{
    public interface IPOS
    {
        Task CreateInvoice(object[] args);
        Task CreateInvoiceItem(object[] args);
        Task CreateProducts(object[] args);
        Task CreateProductsCategory(object[] args);
        Task CreateStockItem(object[] args);
        Task CreateSupplier(object[] args);
        Task<IEnumerable<ProductCategory>> ProductCategory(object[] args);
        Task<IEnumerable<Product>> ProductDetails(object[] args);
        Task UpdateProducts(object[] args);
        Task UpdateProductsCategory(object[] args);
    }
}