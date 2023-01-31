using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilOppgåve
{
    internal class CarDealership
    {
        private string Name { get; set; }
        private string Address {get; set;}
        public List <Car> CarList { get; private set; }


        public CarDealership(string name, string address)
        {
            Name = name;
            Address = address;
            CarList = new List<Car>();
        }
        //En metode som legger til en bil i listen over biler
        public void AddCar(string Brand, string RegistrationNr, int Year, int Distance )
        {
            var CarExists = CarList.FirstOrDefault(c => c.RegistrationNr == RegistrationNr);
            if(CarExists != null)
            {
                Console.WriteLine("That car already exsists");
                return;
            }
   
                var newCar = new Car(Brand, RegistrationNr, Year, Distance);
                CarList.Add(newCar);
            
           
        }
        //En metode som fjerner en bil fra listen over biler, basert på registreringsnummeret til bilen
        public void RemoveCar(string RegistrationNr)
        {
            var RemoveCar = CarList.FirstOrDefault(c => c.RegistrationNr == RegistrationNr);

            if(RemoveCar != null)
            {
                CarList.Remove(RemoveCar);
            }
            
        }
        public void ShowCars()
        {
            foreach(var Car in CarList)
            {
                Console.WriteLine($"{Car.Brand} {Car.RegistrationNr}");
            }
        }
        //En metode som returnerer en liste over alle biler som er mer enn X år gamle
        public List<Car> ShowOldCars(int Year)
        {
            var OldCars = CarList.Where(c => c.Year >= Year).ToList();
            return OldCars;
        }

        //En metode som returnerer en liste over alle biler som har kjørt mer enn Y kilometer
        public List<Car> ShowDistance(int Distance)
        {
          return CarList.Where(c => c.Distance >= Distance).ToList();
        }


    }
}
