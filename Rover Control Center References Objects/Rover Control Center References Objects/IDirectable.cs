using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover_Control_Center_References_Objects
{
    interface IDirectable
    {
        string GetInfo();

        string Explore();

        string Collect();
    }
}
