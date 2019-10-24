using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UnitOfwork : IUnitOfwork
    {
        private readonly DbContext _Context;
        public async Task<int> Complete()
        {
            return await _Context.SaveChangesAsync();
        }

        public UnitOfwork(DbContext Context)
        {
            _Context = Context;

        }
    }
}
