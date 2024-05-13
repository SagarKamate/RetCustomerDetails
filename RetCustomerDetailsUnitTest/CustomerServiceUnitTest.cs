using RetCustomerDetails.Models;
using RetCustomerDetails.Models.Request;
using RetCustomerDetails.Models.Response;
using RetCustomerDetails.Service;
using System.Net;

namespace RetCustomerDetailsUnitTest
{
    public class CustomerServiceUnitTest
    {
        
        [Fact]
        public void  GetCustomerDetailsPositiveTest()
        {
            Request request = new Request() { uniqueIdentifier = "1" };
            
            CustomerService service = new CustomerService();
            Response expectedResponse =  service.GetCustomerDetails(request);

            Assert.Equivalent(expectedResponse.Customer, new Customer()
            {
                id = "1",
                firstName = "Sagar",
                lastName = "Kamate",
                idStatus = "1",
                type = "1"
            });

        }

        [Fact]
        public void GetCustomerDetailsNegativeTest()
        {
            Request request = new Request() { uniqueIdentifier = "11" };

            CustomerService service = new CustomerService();
            Response expectedResponse = service.GetCustomerDetails(request);

            Assert.Equivalent(expectedResponse.Customer, null);
            Assert.Equivalent(expectedResponse.httpStatus, HttpStatusCode.UnprocessableEntity);
            Assert.Equivalent(expectedResponse.errorList, new List<Error>(){
                    new Error() {
                        errorCode = "NEM.ESB.001",
                        description = "Unable to process Customer details."
                    }
                }
            );

        }

        [Fact]
        public void GetCustomerDetailsNotFoundTest()
        {
            Request request = new Request() { uniqueIdentifier = "" };

            CustomerService service = new CustomerService();
            Response expectedResponse = service.GetCustomerDetails(request);

            Assert.Equivalent(expectedResponse, new Response()
            {
                Customer = null,
                errorList = new List<Error>(){
                    new Error() {
                        errorCode = "NEM.ESB.404",
                        description = "Customer details not found."
                    }
                },
                httpStatus = System.Net.HttpStatusCode.NotFound
            });

        }
    }
}
