using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_Task4_CSHarp
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordinates1 = " ABCDEFGHIJ";
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            
            string[,] matrix = new string[11, 11];
            for (int j = 0; j < 11; j++)
            {
                matrix[j, 0] = j.ToString();
                matrix[0, j] = coordinates1[j].ToString();
            }


            for (int j = 0; j < 11; j++)
            {
                for (int k = 0; k < 11; k++)
                {
                    if (j > 0 && k > 0)
                    {
                        matrix[j, k] = "O";
                    }                   
                }                
            }
            Console.WriteLine();
            
            for (int i = 0; i <11; i++)
            {
                Console.WriteLine("Введите координаты кораблей в формате: A1,A2,B3 и тд.");
                string ship = Console.ReadLine();
                for (int j = 0; j < 11; j++) 
                { 
                    
                            if (ship[0] == coordinates1[j])
                            {
                                for(int k = 0; k < 11; k++)
                                    {
                                        Convert.ToString(ship[1]);
                                        int check = Convert.ToInt32(ship[1]);
                                        check = check - 48;
                                        if (check == k)
                                        {
                                            matrix[k, j] = "X";
                                        }
                                    }
                                
                            }
                }
            }
            for (int j = 0; j < 11; j++)
            {
                for (int k = 0; k < 11; k++)
                {
                    Console.Write($"{matrix[j, k]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}
