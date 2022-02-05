using Xunit;

namespace Strategy;

public class ParkingTollTest
{
    [Fact]
    public void Toll_WithFixed_PerHour()
    {
        ParkingToll parkingToll = new ParkingToll(3, new HourCalculation(4));
        int value = parkingToll.Value();
        Assert.Equal(12, value);
    }
    
    [Fact]
    public void Toll_WithInitialValue_ThenFixed_PerHour()
    {
        var parkingToll = new ParkingToll(3, new HourCalculationWithInitialValue(5,2));
        var value = parkingToll.Value();
        Assert.Equal(11, value);
    }
    
    [Fact]
    public void Toll_WithDaily_WhenMore_Than_24H()
    {
        var parkingToll = new ParkingToll(40, new DailyCalculation(20));
        var value = parkingToll.Value();
        Assert.Equal(40, value);
    }
    
    [Fact]
    public void Toll_WithDaily_WhenLess_Than_24H()
    {
        var parkingToll = new ParkingToll(10, new DailyCalculation(20));
        var value = parkingToll.Value();
        Assert.Equal(20, value);
    }
}



