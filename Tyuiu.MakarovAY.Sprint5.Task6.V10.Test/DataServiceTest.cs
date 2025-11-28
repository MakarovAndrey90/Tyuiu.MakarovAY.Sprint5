using Tyuiu.MakarovAY.Sprint5.Task6.V10.Lib;
namespace Tyuiu.MakarovAY.Sprint5.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExistst = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExistst);
        }
    }
}