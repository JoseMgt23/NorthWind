

using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new DebugWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");

ProductService Service = new ProductService(Writer);
Service.Add("Demo", "Azucar refinada");

/*
 * AppLoger y los Writers : Responsabilidad unica 
 * AppLogger: Abierto pero cerrrado 
 * appLogger: Inversion de dependecias. los Modulos de alto nicel son independientes de los detalles de implementacion. 
 * 
 * 
 * */