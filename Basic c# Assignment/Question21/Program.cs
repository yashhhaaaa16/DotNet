namespace Question21;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---- Select One Shape ----");
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Circle");
        Console.WriteLine("3. Rectangle");
        Console.WriteLine("( Choose 1-3 )");
        Console.WriteLine();

        int ch = int.Parse(Console.ReadLine());


        Console.WriteLine("---- Select Operation to perform ----");
        Console.WriteLine("1. Calculate Area");
        Console.WriteLine("2. Calculate Perimeter");
        Console.WriteLine("3. Calculate Area and Perimeter Both");
        Console.WriteLine("( Choose 1-3 )");
        Console.WriteLine();

        int ch1 = int.Parse(Console.ReadLine());



        switch (ch)
        {
            case 1:
                Console.Write("Enter side length of square: ");
                float s = float.Parse(Console.ReadLine());
                printRes(s * s, s * 4, ch1);
                break;
            case 2:
                Console.WriteLine("Enter radius of Circle :");
                float r = float.Parse(Console.ReadLine());
                printRes(3.14*r*r, 2*3.14*r, ch1);
                break;
            case 3:
                Console.WriteLine("Enter length of Rectangle : ");
                float l = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter breadth of Rectangle : ");
                float b = float.Parse(Console.ReadLine());
                printRes(l*b, 2*(l+b), ch1);
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

    }

    public static void printRes (double area, double perimeter, int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine($"Area - {Math.Round(area,2)}");
                break;
            case 2:
                Console.WriteLine($"Perimeter - {perimeter}");
                break;
            case 3:
                Console.WriteLine($"Area - {area} | Perimeter - {perimeter}");
                break;
        }
    }

}
