using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    internal interface ICloneable
    {
        object Clone();
        object DeepCopy();
    }
}
