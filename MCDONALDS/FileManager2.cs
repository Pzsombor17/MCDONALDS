using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDONALDS
{
    internal class FileManager2
    {
        public static List<burger> Readfile(string fileName)
        {
            List<burger> sorok = new List<burger>();
            try
            {
                foreach (string sor in File.ReadAllLines(fileName, Encoding.UTF8).Skip(1))
                {
                    string[] temp = sor.Split(";");

                    sorok.Add(new burger(temp));

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
