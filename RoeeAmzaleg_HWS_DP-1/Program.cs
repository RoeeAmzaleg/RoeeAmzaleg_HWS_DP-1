using System;

namespace RoeeAmzaleg_HWS_DP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******** Clock_HWS ********");
            Console.ForegroundColor = ConsoleColor.Yellow;
            #region Clock
            Clock s1 = Clock.GetTime();
            Clock s2 = Clock.GetTime();

            if (s1 == s2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Clock works!");

            }
            else
            {
                Console.WriteLine("Ooops .... try again ...");

            }
            Console.WriteLine();
            #endregion
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******** Car_HWS ********");
            Console.WriteLine();
            #region Car
            Console.ForegroundColor = ConsoleColor.Yellow;

            Car c1 = new Car(Model.Ferrari, true);
            Car c2 = new Car(Model.Mercedes, true);
            Car c3 = new Car(Model.AsronMartin, true);
            Car c4 = new Car(Model.Tesla, false);
            Garage garage = new Garage();
            garage.cars.Add(c1);
            garage.cars.Add(c2);
            garage.cars.Add(c3);
            garage.cars.Add(c4);


            GarageHandler firstCheck = new FirstCheck();
            GarageHandler mechanicCheck = new MechanicCheck();
            GarageHandler electricCheck = new ElectricCheck();
            GarageHandler diagnosis = new Diagnosis();
            firstCheck.NextCheck(mechanicCheck);
            mechanicCheck.NextCheck(electricCheck);
            electricCheck.NextCheck(diagnosis);
            diagnosis.NextCheck(null);

            garage.cars.ForEach(cars => { if (cars.IsCarRepaired == true) firstCheck.GarageCarHandler(cars); });
            Console.WriteLine(garage);
            #endregion
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("******** Diet_HWS ********");
            Console.WriteLine();
            #region DietFactory

            Console.ForegroundColor = ConsoleColor.Yellow;
            Person costumer = new("Roee", 38, 80, 1.75);
            DietFactory dietFactory = DietFactory.ReturnCreator(costumer);
            Diet diet = dietFactory.ReturnDiet();
            Console.WriteLine($"Costumer:\n{costumer}\n");
            Console.WriteLine($"{diet}\n");
            diet.ReturnMenu().ForEach(MenuItem => Console.WriteLine(MenuItem));
            #endregion
        }
    }
}
