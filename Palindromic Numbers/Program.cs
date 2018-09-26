using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempVar = "";

            string tempVar2 = "";

            for (int i = 10; i < 1000000; i++)
            {
                tempVar2 = "";

                tempVar = Convert.ToString(i);

                char[] varChar = tempVar.ToCharArray();

                for (int j = varChar.Length - 1; j >= 0; j--)
                {
                    tempVar2 += tempVar[j];
                }
                if (Convert.ToString(i) == tempVar2)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}
