using DAL.Common;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static DAL.ViewModels.Finance.FinanceViewModels;

namespace DAL.CRUD
{
    public class Finance : Repository, IFinance
    {
        // create
        public async Task CreateActivity(object[] args)
        {
            var query = @"insert into activitys (Code,Description,CreatedBy,DateCreated,id)
                        values ({0},{1},{2},GETDATE(),newid()) ";
            await UpdateAsync(query, args);

        }
        public async Task CreateChartofAccount(object[] args)
        {
            var query = @"insert into chartOfaccounts (AccountCode,Description,AccountGroup,AccountSubGroup,CreatedBy,DateCreated,Id)
                        values ({0},{1},{2},{3},{4},GETDATE(),newid())";
            await UpdateAsync(query, args);

        }
        public async Task CreateChartofAccountGroup(object[] args)
        {
            var query = @"insert into chartofaccountgroups (GroupCode,SubGroupCode,Description,CreatedBy,DateCreated,Id)
                            values ({0},{1},{2},{3},GETDATE(),newid())";
            await UpdateAsync(query, args);

        }
        public async Task createdoubleentry(object[] args)
        {
            var query = @"
insert into generalledgers(AccountNumber,Folio,Narration,Debit,Credit,Docid,Docno,CreatedBy,DateCreated,id)
values({0},{1},{2},{3},{4},{5},{6},getdate(),NEWID())
insert into generalledgers(AccountNumber,Folio,Narration,Debit,Credit,Docid,Docno,CreatedBy,DateCreated,id)
values({1},{0},{2},{4},{3},{5},{6},getdate(),NEWID())";
            await UpdateAsync(query, args);

        }


        // List
        public async Task<IEnumerable<COA>> ChartOfAccountsDetails()
        {
            return await FindAsync<COA>("select AccountCode,Description,AccountGroup,AccountSubGroup from chartOfaccounts");
        }
        public async Task<IEnumerable<COAGroup>> ChartOfAccountsGroupDetails()
        {
            return await FindAsync<COAGroup>("select GroupCode,SubGroupCode,Description from chartofaccountgroups");
        }
        // Update
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
