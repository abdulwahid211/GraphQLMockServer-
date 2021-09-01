using System.Collections.Generic;
using System.Linq;
using prototypeGraphQLMockServer.Models.Query.Account;

namespace DemoGraphQL.Adapters
{
    public class InMemoryAccountService : Account
    {

        public BankAccount _bankAccount;

        public List<DebitCard> CardDetails;

        public InMemoryAccountService()
        {
            Banking = new Banking();
            AccountName = "Abdul Wahid";
            _bankAccount = new BankAccount() {BankName = "HSBC", AccountNumber = "034534", SortCode = "3455"};
            CardDetails = new List<DebitCard>
            {
                new DebitCard()
                {
                    IsPrimary = true,
                    CardNumber = "23423432"
                },
                new DebitCard()
                {
                    IsPrimary = true,
                    CardNumber = "132243"
                },
                new DebitCard()
                {
                    IsPrimary = true,
                    CardNumber = "3423432"
                }
            };


            Banking.BankAccount = _bankAccount;
            Banking.CardDetails = CardDetails;

        }

        public override DebitCard Create(DebitCard debitCard)
        {
            Banking.CardDetails.Add(debitCard);
            return debitCard;
        }
    }
}
