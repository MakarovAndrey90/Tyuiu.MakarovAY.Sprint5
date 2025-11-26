using Tyuiu.MakarovAY.Sprint5.Task0.V22.Lib;
namespace Tyuiu.MakarovAY.Sprint5.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3); // Получаем реальный путь из Temp папки

            FileInfo fileInfo = new FileInfo(path); // Используем этот путь
            bool fileExistst = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExistst);

        }
    }
}
