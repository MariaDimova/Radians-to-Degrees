using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // , която чете ъгъл в радиани (rad) и го преобразува в градуси (deg). 
            // 1 radian =  57.2957795 degree

            double rad = double.Parse(Console.ReadLine());
            double deg = 57.2957795 * rad;

            Console.WriteLine(Math.Round(deg,1));
        }
    }
}
