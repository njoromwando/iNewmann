using DAL.CRUD;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DAL.ViewModels.Common.Common;
using static DAL.ViewModels.Finance.FinanceViewModels;

namespace iNewmann.Web.Controllers
{
    [ApiController]
    public class FinanceApi : ControllerBase
    {
        private readonly IFinance _finance;
        public FinanceApi(IFinance finance)
        {
            _finance = finance;
        }

        [Route("api/v1/newman/get-chartofaccounts")]
        [HttpGet]
        public async Task<IActionResult> ChartofAccounts()
        {
            return Ok(await _finance.ChartOfAccountsDetails());
        }

        [Route("api/v1/newman/get-chartofaccountgroups")]
        [HttpGet]
        public async Task<IActionResult> ChartofAccountGroups()
        {
            return Ok(await _finance.ChartOfAccountsGroupDetails());
        }

        [Route("api/v1/newman/post-chartofaccountgroup")]
        [HttpPost]
        public async Task<IActionResult> CreateCOAGroup(COAGroup p)
        {

            var responseMessage = new ResponseMessage();
            // data validity check
            if (string.IsNullOrEmpty(p.Description) || string.IsNullOrEmpty(p.SubGroupCode))
            {
                responseMessage.Status = "Info";
                responseMessage.Message = "Provide a valid description and subgroupcode";
            }
            else
                try
                {
                    await _finance.CreateChartofAccountGroup(new object[] {p.GroupCode,p.SubGroupCode,p.Description,"SERVER" });
                    responseMessage.Status = "Success";
                    responseMessage.Message = $"Chartofaccount group { p.Description} Created Succesfully";
                }
                catch (Exception)
                {

                    throw;
                }

            return Ok(responseMessage);
        }

        [Route("api/v1/newman/post-chartofaccount")]
        [HttpPost]
        public async Task<IActionResult> CreateChartofAccounts(COA p)
        {

            var responseMessage = new ResponseMessage();
            // data validity check
            if (string.IsNullOrEmpty(p.Description) || string.IsNullOrEmpty(p.AccountGroup))
            {
                responseMessage.Status = "Info";
                responseMessage.Message = "Provide a valid description and subgroupcode";
            }
            else
                try
                {
                    await _finance.CreateChartofAccountGroup(new object[] { p.AccountCode, p.Description, p.AccountGroup, p.AccountSubGroup, "SERVER" });
                    responseMessage.Status = "Success";
                    responseMessage.Message = $"Chart of account  { p.Description} Created Succesfully";
                }
                catch (Exception)
                {

                    throw;
                }

            return Ok(responseMessage);
        }





    }
}
