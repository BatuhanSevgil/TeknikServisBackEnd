using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IModelService _modelService;

        public ModelController(IModelService modelService)
        {
            _modelService = modelService;
        }
        

        [HttpGet("getall")]
        public IActionResult Getall()
        {
            var result = _modelService.Getall();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }
    }
}
