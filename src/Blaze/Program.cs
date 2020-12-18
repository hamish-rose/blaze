using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Nethereum.Web3;

namespace Blaze
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton(sp => new Web3("https://mainnet.infura.io/v3/61af35ec8ca94a5bb1bc6d8fee06dc37"));

            await builder.Build().RunAsync();
        }
    }
}
