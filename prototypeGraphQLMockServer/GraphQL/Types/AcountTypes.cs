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

    public class ProductType : ObjectType<Product>
    {
        protected override void Configure(IObjectTypeDescriptor<Product> descriptor)
        {
            descriptor.Field(a => a.FirstName).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.Lastname).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.DateOfBirth).Type<NonNullType<DateTimeType>>();
            descriptor.Field(d => d.Contact).ResolveWith<AccountResolvers>(p => p.GetContact()).Type<NonNullType<ContactType>>();
        }
    }

    public class ContactType : ObjectType<Contact>
    {
        protected override void Configure(IObjectTypeDescriptor<Contact> descriptor)
        {
            descriptor.Field(a => a.Address).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.Email).Type<NonNullType<StringType>>();
            descriptor.Field(d => d.Address).ResolveWith<AccountResolvers>(p => p.GetAddress()).Type<NonNullType<AddressType>>();
        }
    }

    public class AddressType : ObjectType<Address>
    {
        protected override void Configure(IObjectTypeDescriptor<Address> descriptor)
        {
            descriptor.Field(a => a.ApartmentNumber).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.Area).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.BuildingName).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.BuildingNumber).Type<NonNullType<StringType>>();
            descriptor.Field(a => a.City).Type<NonNullType<StringType>>();
        }

    }

}
