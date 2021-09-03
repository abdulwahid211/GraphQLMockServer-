﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Data;
using HotChocolate.Types;
using HotChocolate.Types.Relay;
using prototypeGraphQLMockServer.GraphQL.Types;
using prototypeGraphQLMockServer.Models.Query;
using prototypeGraphQLMockServer.Models.Query.Account;
using prototypeGraphQLMockServer.Models.Query.Account.Interfaces;
using System.Text.Json;

namespace prototypeGraphQLMockServer.GraphQL
{
    public class Query
    {
        private readonly Account _account;

        public Query(Account account)
        {
            _account = account;
            string jsonString = JsonSerializer.Serialize(account);

            System.Console.WriteLine("Output Shit:");
            System.Console.WriteLine(jsonString);
        }


        [UseFiltering] 
        public List<DebitCard> CardDetails => _account.Banking.CardDetails;

        public Account account => _account;

    }
}
