using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public class EtkinsDietCreator : DietFactory
    {
        public override Diet ReturnDiet()
        {
            return new EtkinsDiet();
        }
    }
    public class PaleoDietCreator : DietFactory
    {
        public override Diet ReturnDiet()
        {
            return new PaleoDiet();
        }
    }
    public class VegDietCreator : DietFactory
    {
        public override Diet ReturnDiet()
        {
            return new VegDiet();
        }
    }
}
