using System.Globalization;
using System.IO;
using System.Xml.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MakarovAY.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string r = File.ReadAllText(path);
            double x = double.Parse(r, CultureInfo.InvariantCulture);
            double res = Math.Round((4.26 * x) / Math.Sin(x), 2);
            return res;
        }
    }
}
