using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.CRUD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
   
    [ApiController]
    public class POSController : ControllerBase
    {
        private readonly IPOS _pOS;

        public POSController(IPOS pOS)
        {
            _pOS = pOS;
        }
        [Route("api/v1/newman/get-products")]
        [HttpGet]
        public async Task<IActionResult> PostProduct()
        {
            return Ok(await _pOS.ProductDetails(new object[] { }));
        }
    }
}