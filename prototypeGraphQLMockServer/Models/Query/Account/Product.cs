using System;

namespace prototypeGraphQLMockServer.Models.Query.Account
{
    public class Product
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Contact Contact { get; set; } 
    }
}

