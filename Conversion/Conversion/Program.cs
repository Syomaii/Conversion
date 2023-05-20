using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double centimeters;
            int inches,yards,feet;
            Console.Write("Enter length (in centimeters) >>>");
            centimeters = double.Parse(Console.ReadLine());
            inches = (int)Math.Round(centimeters / 2.54);
            yards = inches / 36;
            inches %= 36;
            feet = inches / 12;
            inches %= 12;
            Console.WriteLine($"{yards} yards, {feet} feet(foot), {inches} inches");
            Console.ReadLine();
        }
    }
}
