using HotChocolate;
using prototypeGraphQLMockServer.Models.Query.Account;


namespace prototypeGraphQLMockServer.GraphQL.Mutation
{
    public class MutationAccount
    {
        private readonly Account _account;

        public MutationAccount([Service] Account account)
        {
            _account = account;
        }

        public DebitCard CreateDebitCard(DebitCard debitCard)
        {
            return _account.Create(debitCard);
        }
    }
}
