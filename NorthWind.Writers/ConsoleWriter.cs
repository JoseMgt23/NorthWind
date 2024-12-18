﻿using NorthWind.Entities.interfaces;
using NorthWind.Entities.ValueObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers
{
    internal class ConsoleWriter : IUserActionWriter
    {
        public void Write(UserAction action)
        {
            Console.WriteLine("ConsoleWriter: {0}, {1}, {2}",
                action.CreatedDataTime, action.User, action.Description);
        }
    }
}
