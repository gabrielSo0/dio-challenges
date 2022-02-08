using System.Globalization;
namespace challenge_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string N = "";
            while((N = Console.ReadLine()) != null)
            {
                int number = int.Parse(N);
                if(number < 0 || number > 100)
                {
                    System.Console.WriteLine("Type a value between 0 and 100");
                }
                else
                {
                    if(number == 0)
                    {
                        System.Console.WriteLine("vai ter copa!");
                    }
                    else
                    {
                        System.Console.WriteLine("vai ter duas!");
                    }
                }
            }
        }
    }
}