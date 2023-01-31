using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilOppgåve
{
    public class Car
    {
        public string Brand { get; set; }
        public string RegistrationNr { get;  set; }
        public int Year { get; set; }
        public int Distance { get; set; } 

        public Car(string brand, string registrationNr, int year, int distance)
        {
            Brand = brand;
            RegistrationNr = registrationNr;
            Year = year;
            Distance = distance;
        }
    }
}
