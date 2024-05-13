using RetCustomerDetails.Models.Request;
using RetCustomerDetails.Models.Response;
using System.Diagnostics.CodeAnalysis;

namespace RetCustomerDetails.Service
{
    public interface ICustomerService
    {
        Response GetCustomerDetails(Request request);
    }
}
