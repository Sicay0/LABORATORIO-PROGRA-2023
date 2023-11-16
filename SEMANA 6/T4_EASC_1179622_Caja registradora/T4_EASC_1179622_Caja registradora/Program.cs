// See https://aka.ms/new-console-template for more information
Console.WriteLine("TAREA 2, Caja registradora (?");
Console.WriteLine();

Console.Write("Ingrese su nombre: ");
string nombre = Console.ReadLine();
Console.Write("Ingrese su carné: ");
int carné = int.Parse(Console.ReadLine());

Console.WriteLine(nombre + " - " + carné);
Console.WriteLine();
Console.WriteLine("Ingrese un número: ");

double cant = double.Parse(Console.ReadLine());

int cien, cincuenta, veinte, diez, cinco, uno, cuarto, centimo;

cien = (int)(cant / 100);
cant %= 100;
cincuenta = (int)(cant / 50);
cant%= 50;
veinte= (int)(cant / 20);
cant%= 20;
diez = (int)(cant / 10);
cant%= 10;
cinco = (int)(cant / 5);
cant%= 5;
uno= (int)(cant / 1);
cant %= 1;
cuarto = (int)(cant / .25);
cant %= 0.25;
centimo = (int)(cant / .01);

Console.WriteLine(cien + " de Q 100");
Console.WriteLine(cincuenta + " de Q 50");
Console.WriteLine(veinte + " de Q 20");
Console.WriteLine(diez + " de Q 10");
Console.WriteLine(cinco + " de Q 5");
Console.WriteLine(uno + " de Q 1");
Console.WriteLine(cuarto + " de 25 centavos");
Console.WriteLine(centimo + " de 1 centavo");
Console.ReadKey();