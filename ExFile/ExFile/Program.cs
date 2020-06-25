using System;
using System.Globalization;
using System.IO;

namespace ExFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Path.GetTempPath()+@"\teste\products.csv";
            string directoryPath = Path.GetDirectoryName(sourcePath) + @"\out";
            string targetPath = directoryPath + @"\summary.csv";

            try
            {
                Directory.CreateDirectory(directoryPath);
                
                string[] lines = File.ReadAllLines(sourcePath);
                using StreamWriter sw = File.CreateText(targetPath);
                foreach (string line in lines)
                {
                    string[] columns = line.Split(",");

                    string product = columns[0];

                    double totalValue = double.Parse(columns[1], CultureInfo.InvariantCulture) * double.Parse(columns[2], CultureInfo.InvariantCulture);

                    sw.WriteLine(product +","+ totalValue.ToString("F2",CultureInfo.InvariantCulture));
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de IO: " + e.Message);
            }
        }
    }
}
