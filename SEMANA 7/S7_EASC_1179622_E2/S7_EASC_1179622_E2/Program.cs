// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 2, DIAS DE LA SEMANA");
Console.WriteLine();

//Variables
int dia;


Console.WriteLine("Ingrese un numero del 1 al 7 para indicar cada dia");
dia = int.Parse(Console.ReadLine());

if (dia == 1)
{
    Console.WriteLine("Lunes");
    Console.ReadKey();
}
else if (dia == 2)
{
    Console.WriteLine("Martes");
    Console.ReadKey();
}
else if (dia == 3)
{
    Console.WriteLine("Miercoles");
    Console.ReadKey();
}
else if (dia == 4)
{
    Console.WriteLine("Jueves");
    Console.ReadKey();
}
else if (dia == 5)
{
    Console.WriteLine("Viernes");
    Console.ReadKey();
}
else if (dia == 6)
{
    Console.WriteLine("Sabado");
    Console.ReadKey();
}
else if (dia == 7)
{
    Console.WriteLine("Domingo");
    Console.ReadKey();
}
else
{
    Console.WriteLine("No esta dentro del rango 1 - 7");
}