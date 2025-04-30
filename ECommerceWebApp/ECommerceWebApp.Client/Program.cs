using Blazored.LocalStorage;
using ShoppingCartPlugin.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace ECommerceWebApp.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<ShoppingCartService>();
 
            await builder.Build().RunAsync();
        }
    }
}
 