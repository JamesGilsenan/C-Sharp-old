using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_Inheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {

        }

        public Archmage(string title, string origin) : base(title, origin)
        {

        }

        public override Storm CastRainStorm()
        {
            Storm storm = new Storm("rain", true, Title);

            return storm;
        }

        public Storm CastLightningStorm()
        {
            Storm storm = new Storm("lightning", true, Title);

            return storm;
        }
    }
}
