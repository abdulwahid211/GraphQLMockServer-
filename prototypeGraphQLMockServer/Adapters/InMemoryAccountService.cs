using System.Collections.Generic;
using System.Linq;
using prototypeGraphQLMockServer.Models.Query.Account;
using System.IO;
using System.Text.Json;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DemoGraphQL.Adapters
{
    public class InMemoryAccountService : Account
    {

        public List<DebitCard> CardDetails;
        public InMemoryAccountService()
        {

            string jsonData = System.IO.File.ReadAllText(@".//db.json");

            var accountObjects = JObject.Parse(jsonData);

            string bankingObject = accountObjects["Account"]["Banking"].ToString();

            string productObject = accountObjects["Account"]["Product"].ToString();

            AccountName = accountObjects["Account"]["AccountName"].ToString();

            Product = JsonConvert.DeserializeObject<Product>(productObject);

            Banking = JsonConvert.DeserializeObject<Banking>(bankingObject);

        }

        public override DebitCard Create(DebitCard debitCard)
        {
            Banking.CardDetails.Add(debitCard);
            return debitCard;
        }
    }
}
