

using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.interfaces;

IUserActionWriter Writer = default;

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Application started.");