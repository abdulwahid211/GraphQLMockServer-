using System.Collections.Generic;
using System.Linq;

namespace prototypeGraphQLMockServer.Models.Query.Account.Interfaces
{
    public interface IBanking
    {
         public Banking banking { get; set; }
         public IEnumerable<DebitCard> CardDetails { get; set; }
    }
}