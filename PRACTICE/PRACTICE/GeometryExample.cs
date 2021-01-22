using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE
{
    class Cylinder
    {
         double Radius;
         double Height;
         double BaseArea;
         double LateralArea;
         double TotalArea;
         double Volume;

         void Process()
        {
            Console.WriteLine("Enter the dismenstions of the cylinder");
            Console.Write("Radius : ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height : ");
            Height = Convert.ToDouble(Console.ReadLine());
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
            
            
        }

         void Result()
        {
           
            Console.WriteLine();
            Console.WriteLine("Cylinder Characteristics ");
            Console.WriteLine("Radius: {0} ,Height: {1}",Radius,Height);
            Console.WriteLine("Base: {0:0.00} | Lateral: {1:0.00} | Total: {2:0.00} | Volume: {3:0.00}",BaseArea,LateralArea,TotalArea,Volume);
            
         


        }
        static void Main(string[] args)
        {
            Cylinder objCylinder = new Cylinder();
            objCylinder.Process();
            objCylinder.Result();
            Console.ReadKey();
        }
    }
}
