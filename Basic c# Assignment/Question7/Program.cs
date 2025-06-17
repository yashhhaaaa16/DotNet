namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Salary : ");
            float sal = float.Parse(Console.ReadLine());
            double gross = sal + (0.20 * sal) + (0.40 * sal);
            Console.WriteLine($"Gross Salary = {gross}");
            Console.WriteLine($"Net Salary = {gross - (0.1 * gross)}");
        }
    }
}
