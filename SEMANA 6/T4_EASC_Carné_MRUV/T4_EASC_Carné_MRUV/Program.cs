// See https://aka.ms/new-console-template for more information
Console.WriteLine("TAREA- Problema 1");
Console.WriteLine("MRUV");
Console.WriteLine();

double vf, vo, a, t; 

Console.WriteLine("Ingrese al menos tres valores de la formuala Vf = Vo + at");
Console.Write("Velocidad final= ");
vf = double.TryParse(Console.ReadLine(), out double vfValue) ? vfValue : 0;
Console.Write("Velocidad inicial= ");
vo = double.TryParse(Console.ReadLine(), out double voValue) ? voValue : 0;
Console.Write("Aceleracion = ");
a = double.TryParse(Console.ReadLine(), out double aValue) ? aValue : 0;
Console.Write("tiempo= ");
t = double.TryParse(Console.ReadLine(), out double tValue) ? tValue : 0;    

if (vfValue == 0)
{
    if (voValue == 0 )
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (aValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (tValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else
    {
        vf = vo + (a * t);
        Console.WriteLine("vf = " + vo + " + " + a + " * " + t);
        Console.WriteLine("La velocidad final es = " + vf);
    }
    

}
else if (voValue == 0)
{
    if (vfValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (aValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (tValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else
    {
        vo = vf - (a * t);
        Console.WriteLine("v0 = " + vf + " - " + a + " * " + t);
        Console.WriteLine("La velocidad final es = " + vo);
    }
}
else if (aValue == 0)
{
    if (vfValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (voValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (tValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else
    {
        a = (vf - vo) / t;
        Console.WriteLine("a = (" + vf + " - " + vo + ") / " + t);
        Console.WriteLine("La aceleracion es = " + a);
    }
}
else if (tValue == 0)
{
    if (vfValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (voValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else if (aValue == 0)
    {
        Console.WriteLine("No se tiene suficientes datos");
    }
    else
    {
        t = (vf - vo) / a;
        Console.WriteLine("t = (" + vf + " - " + vo + ") / " + a);
        Console.WriteLine("E tiempo es = " + t);
    }
}
else
{
    Console.WriteLine(vf+ " = " + vo + " + " + a + " * " + t);
}