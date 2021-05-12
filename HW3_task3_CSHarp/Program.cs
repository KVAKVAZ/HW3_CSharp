using System;

namespace HW3_task3_CSHarp
{
    class Program
    {
        static void Main(string[] args)
        {
            string toReverse = Console.ReadLine();
            for (int i=((toReverse.Length)-1);i>=0;i--)
            {
                Console.Write(toReverse[i]);
            }
        }
    }
}
