using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入一個大於零的整數：");
            string input = Console.ReadLine();

            int sum = 1;

            for (int i = 1; i <= int.Parse(input); i++)
            {
                sum *= i;
            }

            Console.WriteLine(input + "的階乘為" + sum);

            Console.Read();
        }
    }
}
