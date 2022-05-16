using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public abstract class GarageHandler
    {
        protected GarageHandler nextHandel;

        public void NextCheck(GarageHandler next)
        {
            nextHandel = next;
        }

        public abstract void GarageCarHandler(Car car);
    }
}
