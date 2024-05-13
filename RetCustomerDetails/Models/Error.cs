using System.Diagnostics.CodeAnalysis;

namespace RetCustomerDetails.Models
{
    [ExcludeFromCodeCoverage]
    public class Error
    {
        public required string errorCode { get; set; }
        public required string description { get; set; }
    }
}
