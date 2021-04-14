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
    public class CustomerGroupController : ControllerBase
    {
        private readonly ICustomerGroupService _customerGroup;

        public CustomerGroupController(ICustomerGroupService customerGroup)
        {
            _customerGroup = customerGroup;
        }


        [HttpGet("getall")]

        public IActionResult Getall()
        {

            var result = _customerGroup.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }


        [HttpPost("add")]

        public IActionResult Add(CustomerGroup customerGroup)
        {
            var result = _customerGroup.Add(customerGroup);
            if (result.Success)
            {
                return Ok(result);
            }

           return BadRequest(result);
        }



    }

}
