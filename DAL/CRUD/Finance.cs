using DAL.Common;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CRUD
{
    internal class Finance : Repository
    {
        public async Task CreateActivity(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public async Task CreateChartofAccount(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public async Task CreateChartofAccountGroup(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }

        public async Task UpdateActivity(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public async Task UpdateChartofAccount(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public async Task UpdateChartofAccountGroup(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public async Task UpdateGeneralLedgers(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public Finance(DataBaseContext context) : base(context)
        {
        }
    }
}
