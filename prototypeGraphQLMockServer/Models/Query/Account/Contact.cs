
namespace prototypeGraphQLMockServer.Models.Query.Account
{
    public class Contact
    {
        public string Email { get; set; }
        public string HomePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string IsMobileVerified { get; set; }
        public Address Address { get; set; }
    }
}
