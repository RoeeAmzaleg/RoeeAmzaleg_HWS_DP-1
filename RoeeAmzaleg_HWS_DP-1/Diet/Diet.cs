using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public abstract class Diet
    {
        private protected string Name { get; set; }
        private protected List<string> Menu { get; set; }

        public virtual List<string> ReturnMenu()
        {
            return Menu;
        }
        public override string ToString()
        {
            return "Diet: " + Name;
        }


    }
}
