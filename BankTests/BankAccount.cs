using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace stringcalculator
{
    public class StringCalculator
    {
        public StringCalculator() { }
        public int Calculate(string arg)
        {
            if (arg == "")
            {
                return 0;
            }
            else
            {
                if (arg[0]=='-') { throw new Exception("negative"); }
                char[] delimeters = { ',', '\n' };
                string[] b = arg.Split(delimeters);
                List<int> termsList = new List<int>();
                foreach (string T in b)
                {
                    termsList.Add(int.Parse(T));
                }
                return termsList.Sum();
            }
        }

        public static void Main()
        {
            StringCalculator ba = new StringCalculator();

            Console.WriteLine("Siema");
        }
    }
}
