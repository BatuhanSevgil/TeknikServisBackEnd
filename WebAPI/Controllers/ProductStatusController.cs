using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entity.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductStatusController : ControllerBase
    {
        private readonly IProductStatusService _productStatus;

        public ProductStatusController(IProductStatusService productStatus)
        {
            _productStatus = productStatus;
        }

        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var result = _productStatus.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(ProductStatus productStatus)
        {

            var result = _productStatus.Add(productStatus);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }
        
    }
}
