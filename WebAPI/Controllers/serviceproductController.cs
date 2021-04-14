using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceProductController : ControllerBase
    {
        private readonly IServiceProductService _productService;
        
        public ServiceProductController(IServiceProductService productService)
        {
            _productService = productService;


        }



        [HttpGet("getall")]
        public IActionResult Getall()
        {


            var result = _productService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add([FromBody] ServiceProduct serviceProduct)
        {
            var result = _productService.Add(serviceProduct);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("addwithcustomer")]
        public IActionResult AddwithCustomer( [FromBody] JObject jObject)
        {

            ServiceProduct serviceProduct = jObject["serviceproduct"].ToObject<ServiceProduct>();
            Customer customer = jObject["customer"].ToObject<Customer>();

            var result = _productService.AddwithCustomer(serviceProduct, customer);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


    }






}
