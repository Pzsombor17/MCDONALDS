using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDONALDS
{
    internal class FileManager
    {
        public static List<Mcdonalds> Readfile(string fileName)
        {
            List<Mcdonalds> sorok = new List<Mcdonalds>();
            try
            {
                foreach (string sor in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
                {
                    string[] temp = sor.Split(";");

                    sorok.Add(new Mcdonalds(temp));

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return sorok;
        }
    }
}
