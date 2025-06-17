namespace Question15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine($"{i} => {(char)i}");
                count++;

                if (count % 10 == 0)
                {
                    Console.WriteLine("Do you want to continue ( Y/N ) : ");
                    char ch = char.Parse(Console.ReadLine());
                    if (ch == 'N')
                        break;
                }
                
            }
        }
    }
}
