using System.Threading.Channels;

namespace AlignmentSpecifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            System.Console.WriteLine("{0,50}", 900);
            System.Console.WriteLine("|{0, 10}|", 400);
            Console.WriteLine("{0:F5}",21.5535353);
            double var2 = 3.14159;
           // Console.WriteLine($"the value of var2 is {var2,10:f3}");
            Console.WriteLine($"jksldjfklsdkfjk{var2}");
            // with index and format component 
            // {index(optional alignment): format component }
            Console.WriteLine("----------------------");

            Console.WriteLine($"jksldjfklsdkfjk{var2,20:C}");
            Console.WriteLine("===========================");
            Console.WriteLine($"jksldjfklsdkfjk{var2:C}");
            Console.WriteLine("{0,50:G} -- General",       var2);
            Console.WriteLine();
        }
    }
}
