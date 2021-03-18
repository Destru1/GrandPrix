namespace GrandPrix2.Factories
{
    using System;
    using System.Collections.Generic;

    using GrandPrix2.Drivers;


    public class DriverFactory
    {
        public static Driver AddDriver(List<string> commandArgs, Car car)
        {
            string driverType = commandArgs[0];
            switch (driverType)
            {
                case "Aggressive":
                    return new AggressiveDriver(commandArgs[1], car);
                case "Endurance":
                    return new EnduranceDriver(commandArgs[1], car);
                default:
                    throw new ArgumentException("Invalid type of driver style.");
            }
        }
    }
}
