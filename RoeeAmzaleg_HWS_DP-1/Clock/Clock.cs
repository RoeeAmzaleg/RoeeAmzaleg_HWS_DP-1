using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    class Clock
    {
        private int Hour;
        private static Clock instance; 

        private static readonly object key = new object();
        private Clock(int hour)
        {
            this.Hour = hour;
        }
        public static Clock GetTime()

        {
            if (instance == null) 

            {
                lock (key) 
                {
                    if (instance == null)
                    {
                        Console.WriteLine("Type your time...");
                        int hour = int.Parse(Console.ReadLine());
                        instance = new Clock(hour);
                    }
                }
            }

            return instance;
        }

    }
}
