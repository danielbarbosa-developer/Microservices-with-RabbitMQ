using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Voyager;
using HotChocolate.AspNetCore.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Application.Api.GraphQL.Queries;
using Application.Abstractions.Interfaces;
using Application.Domain.Repositories;
using Application.Domain.Entities;

namespace Application.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // If you need dependency injection with your query object add your query type as a services.
            // services.AddSingleton<Query>();
            services.AddTransient<IDeliveryQueriesRepository, DeliveryQueriesRepository>();
            services
                .AddRouting()
                .AddGraphQLServer()
                .AddQueryType<DeliveryQueries>()
                .AddType<Restaurant>()
                .AddType<Food>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
             
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseRouting();

            
            app.UseEndpoints(endpoints =>
            {
                // By default the GraphQL server is mapped to /graphql
                // This route also provides you with our GraphQL IDE. In order to configure the
                // the GraphQL IDE use endpoints.MapGraphQL().WithToolOptions(...).
                endpoints.MapGraphQL();
                
                
            });
        }
    }
}
