using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Markdig;
using Markdig.SyntaxHighlighting;

namespace Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { 
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
            });

            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.BrowserConsole()
               .CreateLogger();

            builder.Services.AddSingleton<MarkdownPipeline>(sp =>
              new MarkdownPipelineBuilder()
                  .UseAdvancedExtensions()
                  .UseSyntaxHighlighting()
                  .Build());

            await builder.Build().RunAsync();
        }
    }
}
