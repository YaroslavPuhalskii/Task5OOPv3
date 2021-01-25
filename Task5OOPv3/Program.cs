using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5OOPv3
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator admin = new Administrator() { FirstName = "Пётр", LastName = "Петров"};
            Car car = new Car() { Name = "МАЗ", Capacity = 30.5};
            Driver driver = new Driver() { FirstName = "Егор", LastName = "Макров", rank = 1 };
            City city = new City() { Start = "Гродно", End = "Берлин" };

            TicketBuilder ticketBuilder = new TicketBuilder();
            ticketBuilder.City(city)
                .Car(car)
                .Driver(driver)
                .Build(admin);
        }
    }
}
