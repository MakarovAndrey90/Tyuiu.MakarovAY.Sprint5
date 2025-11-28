using System.IO;
using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MakarovAY.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", "").Replace(".", "");
                    string[] words = line.Split(" ");
                    foreach (string word in words)
                    {
                        if (word.Length == 4)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
