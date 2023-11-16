using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15_S12_EASC_1179622
{
    internal class TrianguloRectangulo
    {
        private double catetoA;
        private double anguloOpuestoA;
        private double catetoB;
    
        public double ObtenerCatetoA()
        {
            catetoA = double.Parse(Console.ReadLine());
            return catetoA;
            Console.WriteLine(catetoA + ".");
        }

        public double ObtenerCatetoB()
        {
            catetoB= catetoA * Math.Atan(anguloOpuestoA); 
            return catetoB;
            Console.WriteLine(catetoB + ".");
        }

        public double ObtenerHipotenusa()
        {
            double Hip;
            double a = Math.Pow(catetoA, 2);
            double b = Math.Pow(catetoB, 2);
            Hip = Math.Sqrt(a+b);
            return Hip;
            Console.WriteLine(Hip + ".");
        }

        public double ObtenerAnguloOpuestoA()
        {
            anguloOpuestoA= double.Parse(Console.ReadLine());
            return anguloOpuestoA;
            Console.WriteLine(anguloOpuestoA + ".");
        }

        public double ObtenerAnguloOpuestoB()
        {
            double catetoOpuestoB;
            catetoOpuestoB = Math.Atan(catetoB/catetoA);
            return catetoOpuestoB;
            Console.WriteLine(catetoOpuestoB + ".");
        }

        public double ObtenerArea()
        {
            double area
            area = (catetoA * catetoB) / 2;
            return area;
            Console.WriteLine(area + ".");
        }
    }
}

