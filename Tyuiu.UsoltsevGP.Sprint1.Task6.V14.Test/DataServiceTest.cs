using Tyuiu.UsoltsevGP.Sprint1.Task6.V14.Lib;
namespace Tyuiu.UsoltsevGP.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string strTest = "À Á A B a b à á";
            var res = ds.CheckLowerCaseRusLetters(strTest);
            var wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
