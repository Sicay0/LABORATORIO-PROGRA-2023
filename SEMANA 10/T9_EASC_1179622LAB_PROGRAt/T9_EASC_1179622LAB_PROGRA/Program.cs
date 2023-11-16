// See https://aka.ms/new-console-template for more information
using T9_EASC_1179622LAB_PROGRA;

Console.WriteLine("Tarea 9");
Console.ReadKey();
Console.WriteLine();

 Motocicleta objMotocicleta = new Motocicleta();

Console.WriteLine("Marca: " + objMotocicleta.Marca);
Console.WriteLine("Modelo" + objMotocicleta.Modelo);
Console.WriteLine("Precio sin IVA " + objMotocicleta.Precio);
Console.WriteLine("Precio con IVA " + ((objMotocicleta.Precio * objMotocicleta.Iva) + objMotocicleta.Precio ));
Console.WriteLine("Monto del IVA " + (objMotocicleta.Precio * objMotocicleta.Iva));
