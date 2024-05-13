using Microsoft.AspNetCore.Mvc;
using RetCustomerDetails.Models;
using RetCustomerDetails.Models.Request;
using RetCustomerDetails.Models.Response;
using RetCustomerDetails.Service;

namespace RetCustomerDetails.Controller
{
    [ApiController]
    [Route("api/v1/[controller]/")]
    public class CustomerController : ControllerBase
    {

        ICustomerService _customerService;

        //Constructor
        public CustomerController()
        {
            _customerService = new CustomerService();
        }

        /// <summary>
        /// Get customer details
        /// http://localhost:5087/api/v1/customer/details?id=1          id paraeter need to pass in query string by default
        /// http://localhost:5087/api/v1/customer/details?id=1          id paraeter need to pass in query string with method attribute as [FromQuery]
        /// http://localhost:5087/api/v1/customer/details/1             id paraeter need to pass in route param with method attribute as [FromRoute]
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("details/{id}")]
        [HttpGet]
        public Response details([FromRoute] string id)
        {
            Request request = new Request() { uniqueIdentifier = id };
            return _customerService.GetCustomerDetails(request);
        }
    }
}
