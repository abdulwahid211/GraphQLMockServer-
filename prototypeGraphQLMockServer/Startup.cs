using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using DemoGraphQL.Adapters;
using HotChocolate;
using HotChocolate.AspNetCore;
using prototypeGraphQLMockServer.GraphQL;
using prototypeGraphQLMockServer.GraphQL.Mutation;
using prototypeGraphQLMockServer.GraphQL.Types;
using prototypeGraphQLMockServer.Models.Query.Account.Interfaces;
using prototypeGraphQLMockServer.Models.Query.Account;

namespace prototypeGraphQLMockServer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Account, InMemoryAccountService>();

            services.AddGraphQLServer()
                .AddType<AccountType>()
                .AddType<BankingType>()
                .AddType<DebitCardType>()
                .AddType<BankAccountType>()
                .AddQueryType<Query>()
                .AddMutationType<MutationAccount>()

                .AddFiltering();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //app.UseDeveloperExceptionPage();
                app.UsePlayground();
            }

            app.UseRouting();

            //app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });

        }
    }
}
