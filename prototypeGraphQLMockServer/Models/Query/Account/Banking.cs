using System.Collections.Generic;
using System.Linq;

namespace prototypeGraphQLMockServer.Models.Query.Account
{
    public class Banking
    {
        public BankAccount BankAccount { get; set; }
        public List<DebitCard> CardDetails { get; set; }
    }
}
