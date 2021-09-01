using System.Linq;

namespace prototypeGraphQLMockServer.Models.Query.Account.Interfaces
{
    public interface IAccountService
    {
        DebitCard Create(DebitCard debitCard);
    }
}