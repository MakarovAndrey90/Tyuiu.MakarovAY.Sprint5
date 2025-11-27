using Tyuiu.MakarovAY.Sprint5.Task4.V5.Lib;
namespace Tyuiu.MakarovAY.Sprint5.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\user\source\repos\Tyuiu.BurdovKS.Sprint5\Tyuiu.MakarovAY.Sprint5.Task2.V16\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExistst = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExistst);
        }
    }
}