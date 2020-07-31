﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rover_Control_Center_References_Objects
{
    class MarsRover : Rover
    {
        public MarsRover(string alias, int yearLanded) : base(alias, yearLanded)
        {
        }

        public override string Explore()
        {
            return "Mars rover is exploring the surface!";
        }

        public override string Collect()
        {
            return "Mars rover is collecting rocks!";
        }
    }
}
