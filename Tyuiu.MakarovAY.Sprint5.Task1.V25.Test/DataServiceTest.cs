using Tyuiu.MakarovAY.Sprint5.Task1.V25.Lib;
namespace Tyuiu.MakarovAY.Sprint5.Task1.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5); // Получаем реальный путь из Temp папки

            FileInfo fileInfo = new FileInfo(path); // Используем этот путь
            bool fileExistst = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExistst);

        }
    }
}
