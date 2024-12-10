using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjets
{
    public class UserAction (string user, string description)
    {
        public DateTime CreatedDataTime { get; } = DateTime.Now;
        public string User => user;
        public string Description => description;

    }
}
