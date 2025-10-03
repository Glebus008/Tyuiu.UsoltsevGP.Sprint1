using Tyuiu.UsoltsevGP.Sprint1.Task4.V27.Lib;
namespace Tyuiu.UsoltsevGP.Sprint1.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 2;
            double wait = 0.152;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
