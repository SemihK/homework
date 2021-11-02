using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DorduncuSoru
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] degrees = new double[181];

            for(int i = 0; i <= 360; i += 2)
            {
                degrees[i / 2] = DegreeToRadian(Convert.ToDouble(i));
            }

            for (int i = 0; i <= 180; i++)
            {
                double sinValue = Math.Sin(degrees[i]);
                double cosValue = Math.Cos(degrees[i]);
                double sum = sinValue + cosValue;
                if (sum < 0)
                {
                    Console.WriteLine("Üzgünüm, reel bir kök yok.");
                }
                else
                {
                    Console.WriteLine("{0} derecenin kökü: {1}", i*2, sum); 
                }
            }
            Console.Read();
        }

        public static double DegreeToRadian(double angle)
        {
            return (Math.PI / 180) * angle;
        }
    }
}
