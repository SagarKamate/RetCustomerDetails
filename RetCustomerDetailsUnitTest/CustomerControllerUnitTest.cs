using RetCustomerDetails.Controller;
using RetCustomerDetails.Models;
using RetCustomerDetails.Models.Response;

namespace RetCustomerDetailsUnitTest
{
    public class CustomerControllerUnitTest
    {
        [Fact]
        public void DetailsMethodPositiveUnitTest()
        {
            //Arrange
            CustomerController customerController = new CustomerController();

            string customerId = "1";
            Response expectedResponse = new Response()
            {
                Customer = new Customer()
                {
                    id = "1",
                    firstName = "Sagar",
                    lastName = "Kamate",
                    organisationName = null,
                    idStatus = "1",
                    type = "1"
                },
                errorList = null,
                httpStatus = System.Net.HttpStatusCode.OK
            };

            //Act
            Response response = customerController.details(customerId);

            //Assert
            Assert.Equivalent(expectedResponse.Customer, response.Customer);
            Assert.Equivalent(expectedResponse.httpStatus, response.httpStatus);
            Assert.Equivalent(expectedResponse.errorList, response.errorList);
            //Assert.StrictEqual(expectedResponse, response);
            //Assert.StrictEqual(expectedResponse.Customer, response.Customer);
            Assert.StrictEqual(expectedResponse.httpStatus, response.httpStatus);
            Assert.StrictEqual(expectedResponse.errorList, response.errorList);
            Assert.NotStrictEqual(expectedResponse, response);
        }

        [Fact]
        public void DetailsMethodNegativeUnitTest()
        {
            //Arrange
            CustomerController customerController = new CustomerController();

            string customerId = "11";
            Response expectedResponse = new Response()
            {
                Customer = null,
                errorList = new List<Error>(){
                    new Error() {
                        errorCode = "NEM.ESB.001",
                        description = "Unable to process Customer details."
                    }
                },
                httpStatus = System.Net.HttpStatusCode.UnprocessableEntity
            };

            //Act
            Response response = customerController.details(customerId);

            //Assert
            Assert.Equivalent(expectedResponse.Customer, null);
            Assert.Equivalent(expectedResponse.httpStatus, response.httpStatus);
            Assert.Equivalent(expectedResponse.errorList, response.errorList);
            //Assert.StrictEqual(expectedResponse, response);
            Assert.StrictEqual(expectedResponse.Customer, response.Customer);
            Assert.StrictEqual(expectedResponse.httpStatus, response.httpStatus);
            //Assert.StrictEqual(expectedResponse.errorList, response.errorList);
            Assert.NotStrictEqual(expectedResponse, response);
        }


        [Fact]
        public void DetailsMethodNotFoundUnitTest()
        {
            //Assert.NotStrictEqual(expectedResponse, response);
        }
    }
}