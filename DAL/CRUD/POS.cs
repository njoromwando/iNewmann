using DAL.Common;
using DAL.POS;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CRUD
{
    public class POS : Repository, IPOS
    {
        // create
        public async Task CreateProductsCategory(object[] args)
        {
            var query = @"insert into productCategories (code,Description,CreatedBy,DateCreated)
                            values ('',{0},{1},getdate())";
            await UpdateAsync(query, args);

        }
        public async Task UpdateProductsCategory(object[] args)
        {
            var query = @"update productCategories set Description={1}
            where Code={0}";
            await UpdateAsync(query, args);

        }
        public async Task CreateSupplier(object[] args)
        {
            var query = @"insert into suppliers (code,name,description,bank,bankbranch,bankaccountno,bankaccountname,accountnumber,createdby,datecreated,id)
                            values({0},{1},{2},{3},{4},{5},{6},{7},{8},getdate(),newid())";
            await UpdateAsync(query, args);

        }
        public async Task CreateInvoice(object[] args)
        {
            var query = @"insert into invoices (invoiceno,suppliercode,invoicedate,createdby,datecreated,id)
                        values ({0},{1},{2},{3},getdate(),newid())";
            await UpdateAsync(query, args);

        }
        public async Task CreateInvoiceItem(object[] args)
        {
            var query = @"insert into chartofaccountgroups (GroupCode,SubGroupCode,Description,CreatedBy,DateCreated,Id)
                            values ({0},{1},{2},{3},GETDATE(),newid())";
            await UpdateAsync(query, args);

        }
        public async Task CreateStockItem(object[] args)
        {
            var query = @"
insert into stockControls(ProductCode,suppliercode,ProductIn,ProductOut,Narration,InvoiceNo,docno,docid,CreatedBy,DateCreated,id)
values({0},{1},{2},{3},{4},{5},{6},{7},{8},getdate(),newid())";
            await UpdateAsync(query, args);

        }

        public async Task<IEnumerable<ProductCategory>> ProductCategory(object[] args)
        {
            return await FindAsync<ProductCategory>("select * from productCategories", args);
        }


        public async Task CreateProducts(object[] args)
        {
            var query = @"insert into products (code,CategoryCode,Name,Description,Unit,Price,SellPrice,Vat,CreatedBy,DateCreated)
                            values ({0},{1},{2},{3},{4},{5},{6},{7},{8},getdate())";
            await UpdateAsync(query, args);

        }
        public async Task UpdateProducts(object[] args)
        {
            var query = @"update products set CategoryCode={1},name={2},Description={3},unit={4},Price={5},SellPrice={6},Vat={7}
            where Code={0}";
            await UpdateAsync(query, args);

        }
        public async Task<IEnumerable<Product>> ProductDetails(object[] args)
        {
            return await FindAsync<Product>("select * from products", args);
        }




        public POS(DataBaseContext context) : base(context)
        {
        }
    }
}
