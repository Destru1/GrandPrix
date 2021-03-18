namespace GrandPrix2.Factories
{


    using System.Collections.Generic;


    using GrandPrix2.Tyres;


    public class CarFactory
    {
        public static Car AddCar(List<string> commandArgs, Tyre tyre)
        {
            return new Car(int.Parse(commandArgs[0]), double.Parse(commandArgs[1]), tyre);
        }
    }
}
