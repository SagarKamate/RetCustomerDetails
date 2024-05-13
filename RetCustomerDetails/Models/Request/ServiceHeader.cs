using System.Diagnostics.CodeAnalysis;

namespace RetCustomerDetails.Models.Request
{

    [ExcludeFromCodeCoverage]
    public class ServiceHeader
    {
        public required string source { get; set; }
        public required string channel { get; set; }
        public required int prefix { get; set; }
        public required int accessToken { get; set; }
    }
}
