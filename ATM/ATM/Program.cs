namespace ATM;

internal class Program
{
    static void Main(string[] args)
    {

        try
        {
            Transaction transaction = new();

            Console.WriteLine("---- Enter Customer Details ----");

            Console.WriteLine("Enter Card Number ( Must be 5 digits ) :");
            transaction.cardNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Pin ( Must be 4 digits ) :");
            transaction.pin = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter withdrawal amount :");
            long amt = long.Parse(Console.ReadLine());
            transaction.WithdrawalAmt = amt;

            Console.WriteLine("Enter Mobile No :");
            transaction.mobileNo = long.Parse(Console.ReadLine());

            Console.WriteLine("Do you want to register your Mob No ( Y/N ) :");
            char mn = char.Parse(Console.ReadLine());

            if (mn == 'Y')
            {
                transaction.OnSMS += MobSMS;
            }
            else
            {
                transaction.OnSMS -= MobSMS;
            }

            Console.WriteLine("Do you want to print slip ( Y/N ) :");
            char ps = char.Parse(Console.ReadLine());

            if (ps == 'Y')
            {
                transaction.OnPrint += PrintSlip;
            }
            else
            {
                transaction.OnPrint -= PrintSlip;
            }

            Console.WriteLine(transaction.withdrawal(amt));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void MobSMS(string value)
    {
        Console.WriteLine($"Mob - {value} has withdrawal successfully from your account");
    }
    private static void PrintSlip(string value)
    {
        Console.WriteLine($"Printing Slip - {value} has been debited ");
    }
}
