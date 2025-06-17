namespace Question10
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter an operator (+, -, *, /) : ");
                char operation = char.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            Console.WriteLine("Division by zero is not allowed");
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        return;
                }

                Console.WriteLine($"Result: {result}");
     

}
    }
}
