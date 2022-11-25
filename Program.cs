using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TestMudBlazorApplication;
using MudBlazor.Services;
using System.Composition;
using TestMudBlazorApplication.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5213/api/Card/Cards") });
builder.Services.AddMudServices();
builder.Services.AddSingleton<ICardService, CardService>();


await builder.Build().RunAsync();
