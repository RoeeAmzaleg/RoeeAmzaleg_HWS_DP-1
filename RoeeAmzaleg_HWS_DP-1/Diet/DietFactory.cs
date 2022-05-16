using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public abstract class DietFactory
    {
        public static DietFactory ReturnCreator(Person Costumer)
        {
            if (Costumer != null)
            {
                if ((Costumer.Age > 40 || Costumer.Age < 70) &&
                     (Costumer.Weight > 50 || Costumer.Weight < 80) &&
                     (Costumer.Height > 1.60))
                {
                    return new PaleoDietCreator();
                }
                if ((Costumer.Age > 40 || Costumer.Age < 60) &&
                     (Costumer.Weight > 50 || Costumer.Weight < 100) &&
                     (Costumer.Height > 1.60))
                {
                    return new EtkinsDietCreator();
                }
                if ((Costumer.Age > 16 || Costumer.Age < 24) &&
                     (Costumer.Weight > 56 || Costumer.Weight < 70) &&
                     (Costumer.Height > 1.60))
                {
                    return new VegDietCreator();
                }
            }
            return null;
        }
        public abstract Diet ReturnDiet();
    }
}