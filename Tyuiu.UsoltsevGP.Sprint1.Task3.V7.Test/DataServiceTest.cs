using Tyuiu.UsoltsevGP.Sprint1.Task3.V7.Lib;
namespace Tyuiu.UsoltsevGP.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double verst = 100;
            var res = ds.VerstsToKilometers(verst);
            Assert.AreEqual(106.68, res);
        }
    }
}
