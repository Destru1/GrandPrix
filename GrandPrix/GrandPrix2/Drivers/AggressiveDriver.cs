namespace GrandPrix2.Drivers
{
  public  class AggressiveDriver : Driver
    {
        private const double AGGRESSIVE_DRIVER_FUEL = 2.7;
        private const double AGGRESSIVE_DRIVER_SPEED = 1.3;
        public AggressiveDriver(string name, Car car)
            :base(name,car,AGGRESSIVE_DRIVER_FUEL)
        {

        }

        public override double Speed => base.Speed * AGGRESSIVE_DRIVER_SPEED;
    }
}
