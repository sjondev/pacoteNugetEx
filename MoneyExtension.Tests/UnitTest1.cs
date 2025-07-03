namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal decimalValue = 1.23M;
        var cents = decimalValue.toCents();
        Assert.AreEqual(123, cents);
    }
}