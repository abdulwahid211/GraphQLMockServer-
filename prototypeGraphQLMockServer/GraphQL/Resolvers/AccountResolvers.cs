using System.Collections.Generic;
using HotChocolate;
using prototypeGraphQLMockServer.Models.Query.Account;

namespace prototypeGraphQLMockServer.GraphQL.Resolvers
{
    public class AccountResolvers
    {

        private readonly Account _account;

        public AccountResolvers([Service] Account inMemoryAccountService)
        {
            _account = inMemoryAccountService;
        }

        public Banking GetBanking() => _account.Banking;

        public BankAccount GetBankAccount() => GetBanking().BankAccount;

        public Address GetAddress() => _account.Product.Contact.Address;

        public Contact GetContact() => _account.Product.Contact;

        public List<DebitCard> GetDebitCards() => GetBanking().CardDetails;
    }
}
