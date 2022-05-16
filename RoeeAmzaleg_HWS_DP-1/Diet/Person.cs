using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoeeAmzaleg_HWS_DP_1
{
    public class Person
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual double Weight { get; set; }
        public virtual double Height { get; set; }

        public Person(string name, int age, double weight, double height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
