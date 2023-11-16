// See https://aka.ms/new-console-template for more information
Console.WriteLine("Serie Fibonacci");
Console.WriteLine();

int rept = 0, valor;

Console.Write("Ingrese un numero entero postivo: ");
valor = int.Parse(Console.ReadLine());

while (rept <= valor)
{
    int a = 0, b = 1, c;

    Console.WriteLine("Para " + rept);

    Console.WriteLine(a);

    while (b < rept)
    {
        Console.WriteLine(b);
        c = a + b;

        a = b;
        b = c;
    };

    rept++;
}