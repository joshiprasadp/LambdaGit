using Amazon.Lambda.AspNetCoreServer;
using Cy.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
namespace CY.TestGet
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            builder.ConfigureServices((services) =>
            {
                services.AddScoped<WltpController>();
                services.AddLogging();
            })
                .UseConfiguration(configuration)
                .UseStartup<StartUp>();
                

        }
    }
}
