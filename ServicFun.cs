using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    internal class ServicFun
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static string GetJson(string userStr)
        {

            string[] arrStringNumbers = userStr.Split(' ');

            List<int> SimplNumbers = new List<int>();

            foreach (var num in arrStringNumbers)
            {
                if (IsPrime(int.Parse(num)))
                {
                    SimplNumbers.Add(int.Parse(num));
                };
            }

            return JsonConvert.SerializeObject(SimplNumbers);
        }

        public static void WritenToFile(string nameFile,string jsonFile)=> File.WriteAllText(nameFile, jsonFile);

       
    }
}
