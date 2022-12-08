using ConsoleApp1;
using System.Security.Cryptography.X509Certificates;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        string userI;

        High h = new High();
        Low l = new Low();


        Console.WriteLine("Wanna find out highest or lowest value? high/low ");
        userI = Convert.ToString(Console.ReadLine());

        if (userI == "high")
        {
            h.highCal();
        }
        else if (userI == "low")
        {
            l.lowCal();
        }
        else
        {
            Console.WriteLine("Ok bye.");
        }
    }
}