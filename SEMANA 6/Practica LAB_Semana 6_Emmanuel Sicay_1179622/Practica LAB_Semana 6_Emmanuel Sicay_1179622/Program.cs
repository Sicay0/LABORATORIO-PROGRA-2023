// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio 1, operaciones aritmeticas");
Console.WriteLine("Ingrese sus valores: ");
int a = 0;
int b = 0;

Console.Write("a = "); a= int.Parse(Console.ReadLine());
Console.Write("b = "); b = int.Parse(Console.ReadLine());

int suma= a + b;
int resta= a - b;
int multi= a * b;
int div= a / b;
int res = a % b;
Console.WriteLine(a + " + " + b + " = " + suma);
Console.WriteLine(a + " - " + b + " = " + resta);
Console.WriteLine(a + " * " + b + " = " + multi);
Console.Write(a + " / " + b + " = " + div);
Console.Write(" residuo " + res);
Console.ReadKey();
Console.Clear();

Console.WriteLine("Ejercicio 2, operaciones booleanas");
Console.WriteLine();
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine();
Console.ReadKey();

bool mayor = a > b;
bool menor = a < b;
bool igual = a == b;

Console.WriteLine(a + " >  " + b + " = " + mayor);
Console.WriteLine(a + " <  " + b + " = " + menor);
Console.WriteLine("a es igual que b " + igual);

Console.ReadKey();
Console.Clear();

Console.WriteLine("Ejercicio 3, jerarquía de operaciones");
int c = 0;
Console.WriteLine();
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.Write("c = "); c = int.Parse(Console.ReadLine());
Console.WriteLine();

double I= a*b+c;
double II= b*(a+c);
double III = a / (b*c );
double IIII = ((3*a)*(2*b)) / (c*c);

Console.WriteLine(a + " * " + b + " + " + c + " = " + I);
Console.WriteLine(a + " * (" + b + " + " + c + ") = " + II);
Console.WriteLine(a + " / " + b + " + " + c + " = " + III);
Console.WriteLine("3(" + a + ") * 2(" + b + ") / " + c + "^2 = " + IIII);

Console.ReadKey();
Console.Clear() ;

Console.WriteLine("Formula Cuadratica");
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);

Console.WriteLine();
Console.ReadKey();

double b1, a1, a2, a3;
b1 = b * b;
a1 = 4 * a * c;

if (a == 0)
{
    Console.WriteLine("Math Error");
    Console.WriteLine("Division sobre 0");
}
else if (a1 < b1)
{
    a3 = b1 - a1;
    a2 = Math.Sqrt(a3);
    Console.WriteLine(a3);
    Console.WriteLine(a2);
    double x = ((-1 * b) + (a2)) / (2 * a);
    Console.WriteLine("-(" + b + ") Raiz(" + b + "^2 + 4(" + a + "*" + c + ") / " + "2(" + a + ") = " + x);
    double x1 = ((-1 * b) - (a2)) / (2 * a);
    Console.WriteLine("-(" + b + ") -Raiz(" + b + "^2 + 4(" + a + "*" + c + ") / " + "2(" + a + ") = " + x1);
    Console.ReadKey();
}
else if (a1 > b1)
{
    a3 = b1 - a1;
    Console.WriteLine("Math Error");
    Console.WriteLine("No existe raiz en los numeros reales para " + a3);
}
//no se que error podría haber 
else
{
    Console.WriteLine("khe?");
}