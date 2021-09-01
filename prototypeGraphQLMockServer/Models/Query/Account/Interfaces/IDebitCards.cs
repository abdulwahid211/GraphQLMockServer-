using System.Linq;

namespace prototypeGraphQLMockServer.Models.Query.Account.Interfaces
{
    public interface IDebitCards
    {
        IQueryable<DebitCard> GetAll();
    }
}