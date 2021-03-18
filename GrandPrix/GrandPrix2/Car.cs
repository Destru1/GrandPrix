namespace GrandPrix2
{

    using System;
    using System.Text;


    using GrandPrix2.Tyres;


    public   class Car
    {

        private const double FUEL_TANK_MAX_CAPACITY = 160;

        private int hp;
        private double fuelAmount;
        private Tyre tyre;



        public Car(int hp,double fuelAmount, Tyre tyre)
        {
            this.Hp = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyre;

        }


        public int Hp
        {
            get
            {
                return this.hp;
            }
            private set
            {
                this.hp = value;
            }
        }

        public double FuelAmount
        {
            get
            {
                return this.fuelAmount;

            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Out of fuel.");
                }
                if (value> FUEL_TANK_MAX_CAPACITY)
                {
                    this.fuelAmount = FUEL_TANK_MAX_CAPACITY;
                }
                else
                {
                    this.fuelAmount = value;

                }
            }
        }

        public Tyre Tyre
        {
            get
            {
                return this.tyre;
            }
            private set
            {
                this.tyre = value;
            }
        }

        public void Refuel(double kilograms)
        {
            this.FuelAmount += kilograms;
        }

        public void ChangeTyres(Tyre newTyre)
        {
            this.Tyre = newTyre;
        }

        public void ReduceFuel(int length, double fuelConsumptionPerKm)
        {
            this.FuelAmount -= length * fuelConsumptionPerKm;
        }
    }
}
