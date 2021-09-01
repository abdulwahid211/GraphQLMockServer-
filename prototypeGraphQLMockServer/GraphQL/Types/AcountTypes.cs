using HotChocolate.Types;
using prototypeGraphQLMockServer.GraphQL.Resolvers;
using prototypeGraphQLMockServer.Models.Query.Account;

namespace prototypeGraphQLMockServer.GraphQL.Types
{


    public class AccountType : ObjectType<Account>
    {
        protected override void Configure(IObjectTypeDescriptor<Account> descriptor)
        {
            descriptor.Field(d => d.Banking).ResolveWith<AccountResolvers>(p => p.GetBanking()).Type<NonNullType<BankingType>>();
            descriptor.Field(d => d.AccountName).Type<NonNullType<StringType>>();
        }
    }


    public class BankingType : ObjectType<Banking>
    {
        protected override void Configure(IObjectTypeDescriptor<Banking> descriptor)
        {
            descriptor.Field(d => d.BankAccount).ResolveWith<AccountResolvers>(p => p.GetBankAccount()).Type<NonNullType<BankAccountType>>(); 
            descriptor.Field(d => d.CardDetails).ResolveWith<AccountResolvers>(p => p.GetDebitCards()) ;
        }
    }

    public class BankAccountType : ObjectType<BankAccount>
    {
        protected override void Configure(IObjectTypeDescriptor<BankAccount> descriptor)
        {
            descriptor.Field(a => a.AccountNumber).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.BankName).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.SortCode).Type<NonNullType<StringType>>();
        }

    }

    public class DebitCardType : ObjectType<DebitCard>
    {

        protected override void Configure(IObjectTypeDescriptor<DebitCard> descriptor)
        {
            descriptor.Field(a => a.CardNumber).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.IsPrimary).Type<NonNullType<BooleanType>>();
        }

    }

}
