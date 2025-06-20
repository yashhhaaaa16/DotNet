namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* string path = @"C:\Users\group023\Documents\Cdac\DotNet\io.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Welcome to Infoway");
                sw.Close();
            }

            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
            }*/

            string path1 = @"C:\Users\group023\Documents\Cdac\io.txt";
           // File.Move(path, path1);

            string path2 = @"C:\Users\group023\Documents\Cdac\DotNet\io-copy.txt";
          //  File.Copy(path1, path2, true);

            File.Delete(path1);


        }
    }
}
