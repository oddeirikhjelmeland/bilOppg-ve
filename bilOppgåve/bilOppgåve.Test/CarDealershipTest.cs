namespace bilOppgåve.Test;

public class CarDealershipTest
{
    [Test]
    public void Test1Constructor()
    {
        var carDealer = new CarDealership("Test","Larvik");
        
        //action
        carDealer.AddCar("Ford", "987123", 2021, 30000);
        
        Assert.AreEqual("Test", carDealer.Name);
        Assert.AreEqual("Larvik", carDealer.Address);
        Assert.AreEqual(1, carDealer.CarList.Count);
    }
    
    [Test]
    public void Test1AddAndRemoveCar()
    {
        var carDealer = new CarDealership("Test","Larvik");
        
        //action
        carDealer.AddCar("Ford", "987123", 2021, 30000);
        carDealer.AddCar("Ford", "927123", 2021, 30000);
        carDealer.RemoveCar("987123");
        carDealer.RemoveCar("987123");
        
        Assert.AreEqual("Test", carDealer.Name);
        Assert.AreEqual("Larvik", carDealer.Address);
        Assert.AreEqual(1, carDealer.CarList.Count);
    }
    
    [Test]
    public void Test1ShowOldCars()
    {
        var carDealer = new CarDealership("Test","Larvik");
        
        //action
        carDealer.AddCar("Ford", "987123", 1998, 30000);
        carDealer.AddCar("Subaru", "917123", 2000, 30000);
        var oldCars = carDealer.ShowOldCars(2000);
        var oldCar = oldCars[0];
        
        Assert.AreEqual("Test", carDealer.Name);
        Assert.AreEqual("Larvik", carDealer.Address);
        Assert.AreEqual(2, carDealer.CarList.Count);
        Assert.AreEqual("Subaru", oldCar.Brand);
        Assert.AreEqual("917123", oldCar.RegistrationNr);
    }
    
    [Test]
    public void Test1ShowCarDistance()
    {
        var carDealer = new CarDealership("Test","Larvik");
        
        //action
        carDealer.AddCar("Ford", "987123", 1998, 30000);
        carDealer.AddCar("Subaru", "917123", 2000, 30000);
        var carDistanceList = carDealer.ShowDistance(2000);
        var distanceCar1 = carDistanceList[0];
        var distanceCar2 = carDistanceList[1];
        Assert.Multiple(() =>
        {
            Assert.That(carDealer.Name, Is.EqualTo("Test"));
            Assert.That(carDealer.Address, Is.EqualTo("Larvik"));
            Assert.That(carDealer.CarList, Has.Count.EqualTo(2));
            Assert.That(distanceCar1.Brand, Is.EqualTo("Ford"));
            Assert.That(distanceCar1.RegistrationNr, Is.EqualTo("987123"));
            Assert.That(distanceCar1.Distance, Is.EqualTo(30000));
            Assert.That(distanceCar2.Brand, Is.EqualTo("Subaru"));
            Assert.That(distanceCar2.RegistrationNr, Is.EqualTo("917123"));
            Assert.That(distanceCar2.Distance, Is.EqualTo(30000));
        });
    }
}