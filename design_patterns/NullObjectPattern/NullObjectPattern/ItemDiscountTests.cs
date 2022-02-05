using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullObjectPattern;

[TestClass]
public class ItemDiscount
{
    [TestMethod(displayName: "Item with Percentage Discount")]
    public void PercentageDiscount()
    {
        var item = new Item("Tenis", 20.0, new PercentageDiscount(0.10));
        Assert.AreEqual("Tenis R$ 18", item.ToString());
    }
    
    [TestMethod(displayName: "Item with Fixed Discount")]
    public void FixedDiscount()
    {
        var item = new Item("Tenis", 20.0, new FixedDiscount(10));
        Assert.AreEqual("Tenis R$ 10", item.ToString());
    }
    
    [TestMethod(displayName: "Item with No Discount")]
    public void NoDiscount()
    {
        var item = new Item("Tenis", 20.0);
        Assert.AreEqual("Tenis R$ 20", item.ToString());
    }
}