using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тест
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Gradus = Convert.ToDouble(Console.ReadLine());
            double Min= Convert.ToDouble(Console.ReadLine());
            double Sec = Convert.ToDouble(Console.ReadLine());
            Angle angle = new Angle(Gradus,Min,Sec);
            double totalRadians = angle.ToRadians();
            Console.WriteLine(totalRadians);
            Console.ReadKey();
        }
      
            
    }



}
