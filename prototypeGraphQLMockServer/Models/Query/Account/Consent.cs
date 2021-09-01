namespace prototypeGraphQLMockServer.Models.Query.Account
{
    public class Consent
    {
        //public TrafficLight ConsentStatus { get; set; }
        public string ConsentExpiry { get; set; }
        public int ConsentDaysRemaining { get; set; }
        public int DepositDaysRemaining { get; set; }
        
    }
}
