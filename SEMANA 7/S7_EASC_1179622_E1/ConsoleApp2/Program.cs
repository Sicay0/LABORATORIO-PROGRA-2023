// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1, && y ||");
Console.WriteLine();

int num;

Console.Write("Ingrese un Numero entero: ");
num = int.Parse(Console.ReadLine());
Console.WriteLine();

if (num >= 1)
{
    Console.WriteLine(num + " es un Entero postivo");
    Console.ReadKey();
}
else if (num <= -1)
{
    Console.WriteLine(num + " es un Entero negativo");
    Console.ReadKey();
}
else
{ 
    Console.WriteLine("Es cero"); 
    Console.ReadKey();
}
