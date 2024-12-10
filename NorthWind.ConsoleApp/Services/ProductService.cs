using NorthWind.Entities.interfaces;
using NorthWind.Entities.ValueObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.ConsoleApp.Services
{
    internal class ProductService(IUserActionWriter writer)
    {
        public void Add(string user, string ProductName)
        {
            UserAction Action = new UserAction(user, $"Created:{ ProductName }");
            writer.Write(Action);
        }
    }
}
