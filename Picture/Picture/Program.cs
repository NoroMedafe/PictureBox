using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            char userSymbole;
            string writeLine = "";

            Console.WriteLine("Введите имя:");
            userName = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            userSymbole = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < userName.Length + 2; i++)
            {
                writeLine += userSymbole;
            }

            Console.WriteLine(writeLine);
            Console.WriteLine(userSymbole + userName + userSymbole);
            Console.WriteLine(writeLine);

            Console.ReadKey();
        }
    }
}
