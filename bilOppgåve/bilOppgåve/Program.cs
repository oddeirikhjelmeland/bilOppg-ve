namespace bilOppgåve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new CarDealership("Test", "Larvik");

            test.ShowCars();
            Console.WriteLine("----------------");
            test.AddCar("Ford", "123456", 2000, 30000);
            test.AddCar("Subaru", "654321", 2005, 100);
            test.AddCar("Toyota", "234561", 2010, 40000);
            test.AddCar("Ram", "6543211", 2015, 1000);
            test.AddCar("Hondai", "345612", 2020, 50000);
            test.AddCar("Kia", "65432111", 2023, 10000);
            test.ShowCars();
            test.RemoveCar("123456");
            test.RemoveCar("123456");
            Console.WriteLine("----------------");
            test.ShowCars();
            Console.WriteLine("----------------");
            var OldCars = test.ShowOldCars(2000);
            
            foreach(var Car in OldCars)
            {
                Console.WriteLine($"{Car.Brand} {Car.RegistrationNr}");
            }
            Console.WriteLine("----------------");
            var CarDistance = test.ShowDistance(20000);
            foreach (var Car in CarDistance)
            {
                Console.WriteLine($"{Car.Brand} {Car.Distance}");
            }
        }
    }
}