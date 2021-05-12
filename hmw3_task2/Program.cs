using System;

namespace hmw3_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] contacts = new string[5, 2];
            for (int j=0;j<5;j++)
            {
                for (int k=0;k<2;k++)
                {
                    if (k==0)   
                    { 
                    Console.WriteLine("Введите имя контакта");
                    contacts[j, 0] = Console.ReadLine();
                    }
                    if (k==1)
                    { 
                    Console.WriteLine("Введите телефон/email контакта");
                    contacts[j, 1] = Console.ReadLine();
                    }
                }
                
            }
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write($"{contacts[j,k]}   ");

                }
                Console.WriteLine();
            }
        }
    }
}