using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public class EtkinsDiet : Diet
    {
        public EtkinsDiet()
        {
            Name = "EtkinsDiet";

            Menu = new()
            {
                "Chicken",
                "Salmon",
                "Broccoli",
                "Butter",
                "Cheese",
                "Yogurt"
            };
        }
    }
    public class PaleoDiet : Diet
    {
        public PaleoDiet()
        {
            Name = "PaleoDiet";

            Menu = new()
            {
                "Eggs",
                "Meat",
                "Broccoli",
                "Apple",
                "Fish",
                "Nuts"
            };
        }
    }
    public class VegDiet : Diet
    {
        public VegDiet()
        {
            Name = "VegDiet";

            Menu = new()
            {
                "Carrot",
                "Zukini",
                "Tomato",
                "Lettuce",
                "Tofu",
                "Tehini"
            };
        }
    }
}
