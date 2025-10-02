using Tyuiu.UsoltsevGP.Sprint1.Task2.V14.Lib;
namespace Tyuiu.UsoltsevGP.Sprint1.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 20;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(-253, res);
        }
    }
}
