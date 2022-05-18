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

            Console.WriteLine("Введите имя:");
            userName = Console.ReadLine();
            Console.WriteLine("Введите символ:");
            userSymbole = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {

                if (i ==1)
                {
                    Console.WriteLine(userSymbole + userName + userSymbole);
                }
                else
                {

                    for (int j = 0; j < userName.Length + 2; j++)
                    {
                        Console.Write(userSymbole);

                        if (j >= userName.Length + 1)
                            Console.Write("\n");

                    }

                }
               
            }

            Console.ReadKey();
        }
    }
}
