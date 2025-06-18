using System;

namespace Question16;

internal class Program
{
    static void Main(string[] args)
    {
        /* Console.WriteLine("Enter a Number : ");
         int num = int.Parse(Console.ReadLine());
         int i;
         if (num <= 1)
         {
             Console.WriteLine($"{num} is not a Prime Number");
             return;
         }
             for (i = 2; i < num; i++)
         {
             if (num % i == 0)
                 break;
         }
         if (i == num)
         {
             Console.WriteLine($"{num} is a Prime Number");
         }
         else
         {
             Console.WriteLine($"{num} is not a Prime Number");
         }*/

        Console.WriteLine("First 25 Prime Numbers are : ");
        int count = 0;

        /*for (int num = 2; count < 25; num++)
        {
            bool isPrime = true;

            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write($"{count+1} - {num} \n");
                count++;
            }
        }*/

        /*int num = 2;
        while (count < 25)
        {
            bool isPrime = true;
            int i = 2;
            while (i <= num/2)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }
            if (isPrime) {
                Console.Write($"{count + 1} - {num} \n");
                count++;
            }
            num++;
        }*/

        int num = 2;
        do
        {
            bool isPrime = true;
            int i = 2;
            while (i <= num / 2)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
                i++;
            }
            if (isPrime)
            {
                Console.Write($"{count + 1} - {num} \n");
                count++;
            }
            num++;
        }
        while (count < 25);

        
        
    }
}
