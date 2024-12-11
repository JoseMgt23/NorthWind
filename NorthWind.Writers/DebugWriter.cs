using NorthWind.Entities.interfaces;
using NorthWind.Entities.ValueObjets;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers
{
   internal class DebugWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Debug.WriteLine("ConsoleWriter: {0}, {1}, {2}",
                        action.CreatedDataTime, action.User, action.Description);
        }
    }
}
