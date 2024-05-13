using RetCustomerDetails.Models;
using RetCustomerDetails.Models.Request;
using RetCustomerDetails.Models.Response;

namespace RetCustomerDetails.Service
{
    public class CustomerService : ICustomerService
    {
        internal Customer _customer;

        public CustomerService()
        {
            _customer = new Customer()
            {
                id = "1",
                firstName = "Sagar",
                lastName = "Kamate",
                idStatus = "1",
                type = "1"
            };
        }

        public Response GetCustomerDetails(Request request)
        {
            //Customer ID is null
            if (string.IsNullOrEmpty(request.uniqueIdentifier))
            {
                Error error = new Error()
                {
                    errorCode = "NEM.ESB.404",
                    description = "Customer details not found."
                };

                List<Error> errors = new List<Error>();
                errors.Add(error);

                return new Response()
                {
                    httpStatus = System.Net.HttpStatusCode.NotFound,
                    errorList = errors
                };
            }
            //Customer ID is invalid
            else if (request.uniqueIdentifier.Length > 1)
            {
                Error error = new Error()
                {
                    errorCode = "NEM.ESB.001",
                    description = "Unable to process Customer details."
                };

                List<Error> errors = new List<Error>();
                errors.Add(error);

                return new Response()
                {
                    httpStatus = System.Net.HttpStatusCode.UnprocessableEntity,
                    errorList = errors
                };
            }
            //Customer Id is valid and return result
            else
            {
                return new Response()
                {
                    Customer = _customer,
                    httpStatus = System.Net.HttpStatusCode.OK
                };
            }
        }
    }
}
