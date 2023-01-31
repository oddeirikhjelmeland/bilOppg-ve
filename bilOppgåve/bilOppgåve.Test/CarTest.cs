namespace bilOppgåve.Test;

public class CarTest
{
    [Test]
    public void Test1CarConstructor()
    {
        //assign
        var car = new Car("Ford", "123456", 2000, 30000);
        
        //assert
        Assert.AreEqual("Ford", car.Brand);
        Assert.AreEqual("123456", car.RegistrationNr);
        Assert.AreEqual(2000, car.Year);
        Assert.AreEqual(30000, car.Distance);
    }
    
    [Test]
    public void Test2CarConstructor()
    {
        //assign
        var car = new Car("Subaru", "654321", 2005, 100);
        
        //assert
        Assert.AreEqual("Ford", car.Brand);
        Assert.AreEqual("123456", car.RegistrationNr);
        Assert.AreEqual(2000, car.Year);
        Assert.AreEqual(30000, car.Distance);
    }
}