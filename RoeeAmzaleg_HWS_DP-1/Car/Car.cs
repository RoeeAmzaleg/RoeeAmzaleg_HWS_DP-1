using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public class Car : GarageHandler
    {
        public bool IsCarRepaired { get; set; }
        public Model model { get; set; }

        public Car(Model model, bool isCarRepaired)
        {
            IsCarRepaired=isCarRepaired;
            this.model=model;
        }

        public override void GarageCarHandler(Car car)
        {

        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
