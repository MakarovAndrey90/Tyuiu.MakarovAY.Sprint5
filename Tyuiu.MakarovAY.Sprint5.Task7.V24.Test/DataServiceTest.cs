using System.Text;
using Tyuiu.MakarovAY.Sprint5.Task7.V24.Lib;
namespace Tyuiu.MakarovAY.Sprint5.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Hello world", Encoding.UTF8);

            string outputPath = ds.LoadDataAndSave(inputPath);

            FileInfo fileInfo = new FileInfo(outputPath);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}