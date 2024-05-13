using System.Diagnostics.CodeAnalysis;

namespace RetCustomerDetails.Models
{
    [ExcludeFromCodeCoverage]
    public class Customer
    {
        public required string id { get; set; }

        public required string type { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? organisationName { get; set; }

        public required string idStatus { get; set; }
    }
}
