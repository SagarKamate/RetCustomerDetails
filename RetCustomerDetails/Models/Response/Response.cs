using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace RetCustomerDetails.Models.Response
{
    [ExcludeFromCodeCoverage]
    public class Response
    {
        public Customer? Customer { get; set; }

        public HttpStatusCode httpStatus { get; set; }
        public List<Error>? errorList { get; set; }
    }
}
