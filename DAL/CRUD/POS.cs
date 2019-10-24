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

        public async Task CreateProducts(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public async Task UpdateProducts(object[] args)
        {
            var query = @"";
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
