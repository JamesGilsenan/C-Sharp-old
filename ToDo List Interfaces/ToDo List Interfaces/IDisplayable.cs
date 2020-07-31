using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_List_Interfaces
{
    interface IDisplayable
    {
        string HeaderSymbol { get; }

        void Display();
    }
}
