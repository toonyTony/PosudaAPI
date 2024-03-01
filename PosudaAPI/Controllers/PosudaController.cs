using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PosudaAPI.Models;
using static PosudaAPI.Models.PosudaModel;

namespace PosudaAPI.Controllers

{
    [Route("api/PosudaAPI")]
    [ApiController]
    [ProducesResponseType(200)]
    public class PosudaController : ControllerBase
    {
        [HttpGet("first")]
        public IEnumerable<SalesRegistration> GetPosudasByQuantityDescending()
        {
            return PosudaStore.saleList.OrderByDescending(r => r.QuantitySold);
        }

        [HttpGet("second")]
        public IEnumerable<SalesRegistration> GetPosudasByPriceDescending()
        {
            return PosudaStore.saleList.OrderByDescending(r => r.TotalCost);
        }
    }
}
