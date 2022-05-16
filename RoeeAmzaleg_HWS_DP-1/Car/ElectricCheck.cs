using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public class ElectricCheck : GarageHandler
    {
        public override void GarageCarHandler(Car car)
        {
            Random random = new Random();
            int rnd = random.Next(1, 11);
            if (rnd >= 6)
            {
                Console.WriteLine($"{car.model} You passed the electric test successfully , You are transferred to the next test");
                if (nextHandel!=null)
                    nextHandel.GarageCarHandler(car);
                else
                    Console.WriteLine("The tretment is over");
            }
            else
            {
                Console.WriteLine($"{car.model} We found a problem, your car is getting fixed ");
                car.IsCarRepaired = false;
            }
        }
    }
}
