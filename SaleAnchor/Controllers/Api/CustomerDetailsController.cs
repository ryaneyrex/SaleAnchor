using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaleAnchor.Data;
using SaleAnchor.Models;

namespace SaleAnchor.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/CustomerDetails")]
    public class CustomerDetailsController : Controller
    {
        private ICustomerRepository _repository;

        public CustomerDetailsController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        // PUT: api/CustomerDetails - Create customer details
        [HttpPut("")]
        public async Task<IActionResult> CustomerDetailsCreate([FromBody] CustomerDetailsModel customerDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _repository.CustomerDetails_Create(customerDetails);
            await _repository.SaveChangesAsync();

            return CreatedAtAction("GetCustomerAddressDetails", new { id = customerDetails.Id }, customerDetails);
        }

        // PUT: api/CustomerDetails - Update customer details
        [HttpPut("")]
        public async Task<IActionResult> CustomerDetailsUpdate([FromBody] CustomerDetailsModel customerDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.CustomerDetails_Update(customerDetails);
            await _repository.SaveChangesAsync();

            return CreatedAtAction("GetCustomerAddressDetails", new { id = customerDetails.Id }, customerDetails);
        }


        //// POST: api/CustomerAddressDetails
        //[HttpPost("")]
        //public async Task<IActionResult> PostCustomerAddressDetails([FromBody] CustomerAddress customerAddressDetails)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _repository.AddCustomerAddressDetails(customerAddressDetails);
        //    await _repository.SaveChangesAsync();

        //    return CreatedAtAction("GetCustomerAddressDetails", new { id = customerAddressDetails.Id }, customerAddressDetails);
        //}

    }
}