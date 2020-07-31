using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    class Mage : Pupil
    {
        public Mage(string title) : base(title)
        {

        }

        public Mage(string title, string origin) : base(title, origin)
        {

        }

        public virtual Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", false, Title);

            return storm;
        }
    }
}
