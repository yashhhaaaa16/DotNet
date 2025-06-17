using System.Globalization;

namespace Question13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in ( dd/mm/yy ) format : ");
            String date = Console.ReadLine();

            DateTime date1 = DateTime.ParseExact(date, "dd/MM/yy",CultureInfo.InvariantCulture);

            int days = DateTime.DaysInMonth(date1.Year, date1.Month);
            string monthName = date1.ToString("MMMM");
            //String month = date1.Month.ToString();

            Console.WriteLine($"Month - {monthName}");
            Console.WriteLine($"Total Number of Days - {days}");
            /*String monthName = month switch
            { 
                "1" => "Jan",
                "2" => "Feb",
                "3" => "Mar",
                "4" => "Apr",
                "5" => "May",
                "6" => "Jun",
                "7" => "July",
                "8" => "Aug",
                "9" => "Sep"

            };*/
        }
    }
}
