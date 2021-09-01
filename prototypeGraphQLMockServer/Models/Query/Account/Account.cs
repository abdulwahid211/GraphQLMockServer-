namespace prototypeGraphQLMockServer.Models.Query.Account
{
    public abstract class Account
    {
        public Banking Banking { get; set; }
        public string AccountName { get; set; }
        //public Product Product { get; set; }
        //public Consent Consent { get; set; }

        public abstract DebitCard Create(DebitCard debitCard);
    }
}
