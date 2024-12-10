using NorthWind.Entities.ValueObjets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.interfaces;

public interface IUserActionWriter
{
    void Write(UserAction action);
}
