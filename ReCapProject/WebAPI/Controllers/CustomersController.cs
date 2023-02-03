using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result=_customerService.GetAll();
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Customer customer)
        {
            var result=_customerService.Add(customer);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            var result = _customerService.Delete(id);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }

        [HttpPatch("Update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result.Success)
            {
                return Ok(result.Success);
            }
            return BadRequest(result.Message);
        }
    }
}
