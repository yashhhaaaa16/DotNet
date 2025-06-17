namespace Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Employee Number : ");
                int empNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Department Number : ");
                int deptNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Designation Code (M, S, A, s, a) : ");
                char desCode = char.Parse(Console.ReadLine());
                Console.WriteLine();

                String designation = desCode switch
                {
                    'M' => "Manager",
                    'S' => "Supervisor",
                    'A' => "Analyst",
                    's' => "Sales Person",
                    'a' => "Accountant",
                    _ => throw new Exception("Invalid Designation Code")
                };

                String departmentName = deptNo switch
                {
                    10 => "Purchase",
                    20 => "Sales",
                    30 => "Production",
                    40 => "Marketing",
                    50 => "Accounts",
                    _ => throw new Exception("Invalid Department Number")
                };

                Console.WriteLine("-----Employee Details-----");
                Console.WriteLine($"Employee Number - {empNo}");
                Console.WriteLine($"Department Number - {deptNo}");
                Console.WriteLine($"Department Name - {departmentName}");
                Console.WriteLine($"Designation Code - {desCode}");
                Console.WriteLine($"Designation - {designation}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

    }
	
    }
}
