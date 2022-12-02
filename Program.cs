using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TestMudBlazorApplication;
using MudBlazor.Services;
using System.Composition;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://10.108.130.43:5213/api/Card/Cards") });
builder.Services.AddMudServices();


await builder.Build().RunAsync();
