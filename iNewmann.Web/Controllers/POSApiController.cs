using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.CRUD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DAL.ViewModels.Common.Common;
using static DAL.ViewModels.POS.POSViewModels;

namespace iNewmann.Web.Controllers
{
   
    [ApiController]
    public class POSApiController : ControllerBase
    {
        private readonly IPOS _pOS;

        public POSApiController(IPOS pOS)
        {
            _pOS = pOS;
        }
        [Route("api/v1/newman/get-products")]
        [HttpGet]
        public async Task<IActionResult> PostProduct()
        {
            return Ok(await _pOS.ProductDetails(new object[] { }));
        }

        [Route("api/v1/newman/post-products")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct (ProductViewModels p)
        {

            var responseMessage = new ResponseMessage();
            // data validity check
            if (string.IsNullOrEmpty(p.Name)||string.IsNullOrEmpty(p.Description))
            {
                responseMessage.Status = "Info";
                responseMessage.Message = "Provide a valid name and description of product";
            }
            else
                try
                {
                   await _pOS.CreateProducts(new object[] { p.Code, p.CategoryCode, p.Name.ToUpper(), p.Description.ToUpper(), p.Unit, p.Price,
                                                             p.SellPrice, p.Vat, p.CreatedBy});
                    responseMessage.Status = "Success";
                    responseMessage.Message = $"Product {p.Name+" "+ p.Description} Created Succesfully";
                }
                catch (Exception)
                {

                    throw;
                }

            return Ok(responseMessage);
        }

        [Route("api/v1/newman/post-supplier")]
        [HttpPost]
        public async Task<IActionResult> CreateSupplier(SupplierViewModel p)
        {

            var responseMessage = new ResponseMessage();
            // data validity check
            if (string.IsNullOrEmpty(p.Name) || string.IsNullOrEmpty(p.Description))
            {
                responseMessage.Status = "Info";
                responseMessage.Message = "Provide a valid name and description of product";
            }
            else
                try
                {
                    await  _pOS.CreateSupplier(new object[] { p.Code, p.Name, p.Description, p.Bank, p.BankBranch, p.BankAccountNo, p.BankAccountname, p.AccountNumber, "SERVER" });
                    responseMessage.Status = "Success";
                    responseMessage.Message = $"Supplier {p.Name + " " + p.Description} Created Succesfully";
                }
                catch (Exception)
                {

                    throw;
                }

            return Ok(responseMessage);
        }


        
    }
}