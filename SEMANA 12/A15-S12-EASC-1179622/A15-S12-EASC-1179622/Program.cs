// See https://aka.ms/new-console-template for more information
using A15_S12_EASC_1179622;

Console.WriteLine("Triangulo Rectangulo");
TrianguloRectangulo Triangulo = new TrianguloRectangulo();

Console.Write("Ingrese el valor del cateto Opuesto: ");
Triangulo.ObtenerCatetoA();
Console.Write("Ingrese el valor del angulo Opuesto al cateto: ");
Triangulo.ObtenerAnguloOpuestoA();

Console.WriteLine("Cateto adyacente = "+ Triangulo.ObtenerCatetoB());
Console.WriteLine("Hipotenusa = " + Triangulo.ObtenerHipotenusa());
Console.WriteLine("angulo opusto a adyacente = " + Triangulo.ObtenerAnguloOpuestoB());
Console.WriteLine("Area = " + Triangulo.ObtenerArea);