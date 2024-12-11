

using Microsoft.Extensions.Hosting;
using NorthWind.Entities.interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Entities.Interface;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();
Builder.Services.AddNorthWindServices();

using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");

/*
 * AppLoger y los Writers : Responsabilidad unica 
 * AppLogger: Abierto pero cerrrado 
 * appLogger: Inversion de dependecias. los Modulos de alto nicel son independientes de los detalles de implementacion. 
 * 
 * 
 * */