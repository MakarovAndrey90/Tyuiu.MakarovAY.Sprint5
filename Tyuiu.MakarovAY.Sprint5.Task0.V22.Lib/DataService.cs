using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.MakarovAY.Sprint5.Task0.V22.Lib
{
    public class DataService : ISprint5Task0V22
    {
        public string SaveToFileTextData(int x)
        {
            string rn = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = (Math.Pow((1.0 - (double)x), 2) / (-3.0 * (double)x));
            z = Math.Round(z, 2);
            File.WriteAllText(rn, z.ToString());
            return rn; //
        }
    }
}
