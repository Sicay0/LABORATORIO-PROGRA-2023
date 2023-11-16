// See https://aka.ms/new-console-template for more information
Console.WriteLine("Secuencias");
double variable, ente=1, resultado, resultado1;

Console.WriteLine("Ingrese un numero entero postivo");
variable= double.Parse(Console.ReadLine());
Console.WriteLine("Primero");
while (ente <= variable)
{
    resultado = 1 / ente;
    Console.WriteLine("1 / " + ente + " = " + resultado);

    resultado1 = 1 / Math.Pow(2, ente);
    Console.WriteLine("1 / 2^" + ente + " = " + resultado1);
    Console.WriteLine();
    Console.ReadKey();
    ente++;
}
Console.ReadKey();
Console.Clear();

double x, x1, n,n1, a, a1, k = 0, resultado2;
Console.WriteLine("Ingrese tres valores para la sumatoria de k = 0 hasta n de x^k*a^n-k");
Console.Write("valor n ");
n = int.Parse(Console.ReadLine());
Console.Write("valor de x ");
x = int.Parse(Console.ReadLine());
Console.Write("valor de a ");
a = int.Parse(Console.ReadLine());

while (k <= n)
{
    n1 = n - k;
    a1 = Math.Pow(a, n1);
    x1 = Math.Pow(x, k);
    resultado2 = x1 * a1;

    Console.WriteLine(x + "^" + k + "*" + a + "^" + n1 + " = " + resultado2);
    k++;
}