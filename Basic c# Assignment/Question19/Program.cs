namespace Question19;

internal class Program
{
    static void Main(string[] args)
    {
        Boolean b;
        do
        {
            Console.WriteLine("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            b = isPrime(num);

        }
        while (b);

        
    }
    public static bool isPrime(int num) 
    {
        Boolean ch = check(num);

        if (ch)
        {
            int i;

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
            }
            return false;
        }
        else
        {
            return true;
        }

    }

    public static bool check(int num) 
    {
        if (num < 0)
        {
            Console.WriteLine($"{num} is a Negative Number \n");
            Console.WriteLine("Please re-enter the Number ");
            return false;
        }
        else
        {
            return true;
        }
    }

}
