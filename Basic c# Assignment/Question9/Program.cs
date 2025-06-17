namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Basic Salary : ");
            double sal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total Sales Amount : ");
            int sales = int.Parse(Console.ReadLine());
            /*double c = 0;
            if (sales >= 5000 && sales <= 7500)
            {
                sal = (0.03 * sales) + sal;
                c = 0.03 * sales;
                Console.WriteLine($"Net Salary = {sal} and Commission Earned = {c}");
            }
            else if (sales >= 7501 && sales <= 10500)
            {
                sal = (0.08 * sales) + sal;
                c = 0.08 * sales;
                Console.WriteLine($"Net Salary = {sal} and Commission Earned = {c}");
            }
            else if (sales >= 10501 && sales <= 15000)
            {
                sal = (0.11 * sales) + sal;
                c = 0.11 * sales;
                Console.WriteLine($"Net Salary = {sal} and Commission Earned = {c}");
            }
            else if (sales > 15000)
            {
                sal = (0.15 * sales) + sal;
                c = 0.15 * sales;
                Console.WriteLine($"Net Salary = {sal} and Commission Earned = {c}");
            }
            else
            {
                Console.WriteLine("Invalid Salary");
            }*/


            double commissionRate = sales switch
            {
                >= 5000 and <= 7500 => 0.03,
                >= 7501 and <= 10500 => 0.08,
                >= 10501 and <= 15000 => 0.11,
                > 15000 => 0.15,
                _ => 0
            };

            double commission = commissionRate * sales;
            sal += commission;
            Console.WriteLine($"Net Salary = {sal} and Commission Earned = {commission}");

        }
    }
}
