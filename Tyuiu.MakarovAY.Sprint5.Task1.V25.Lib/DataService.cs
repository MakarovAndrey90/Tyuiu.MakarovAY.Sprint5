using System.IO;
using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MakarovAY.Sprint5.Task1.V25.Lib
{
    public class DataService : ISprint5Task1V25
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string rn = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            if (File.Exists(rn))
            {
                File.Delete(rn);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Abs(3 * x + 1.2) < 0.0001)
                {
                    y = 0;
                }
                else 
                {
                    y = Math.Round(((2 * Math.Sin(x)) / (3 * x + 1.2)) + Math.Cos(x) - 7 * x * 2, 2);
                }
                strY = y.ToString();
                if (x != stopValue)
                {
                    File.AppendAllText(rn, strY + Environment.NewLine);
                }
                else 
                {
                    File.AppendAllText(rn, strY);

                }


            }

            return rn;
        }
    }
}
