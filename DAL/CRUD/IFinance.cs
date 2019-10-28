using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.ViewModels.Finance;

namespace DAL.CRUD
{
    public interface IFinance
    {
        Task<IEnumerable<FinanceViewModels.COA>> ChartOfAccountsDetails();
        Task<IEnumerable<FinanceViewModels.COAGroup>> ChartOfAccountsGroupDetails();
        Task CreateActivity(object[] args);
        Task CreateChartofAccount(object[] args);
        Task CreateChartofAccountGroup(object[] args);
        Task UpdateActivity(object[] args);
        Task UpdateChartofAccount(object[] args);
        Task UpdateChartofAccountGroup(object[] args);
        Task UpdateGeneralLedgers(object[] args);
    }
}