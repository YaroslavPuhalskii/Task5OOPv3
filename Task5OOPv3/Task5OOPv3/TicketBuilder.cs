using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOPv3
{
    class TicketBuilder
    {
        List<City> c = new List<City>();
        List<Driver> d = new List<Driver>();

        Car car;


        public Road Build(Administrator admin)
        {
            Road road = new Road() { admin = admin, cities = c, drivers = d, car = car };
            car = null;
            c = new List<City>();
            d = new List<Driver>();

            return road;
        }

        public TicketBuilder City(City city)
        {
            c.Add(city);
            return this;
        }

        public TicketBuilder Driver(Driver driver)
        {
            d.Add(driver);
            return this;
        }

        public TicketBuilder Car(Car car)
        {
            this.car = car;
            return this;
        }

    }
}
