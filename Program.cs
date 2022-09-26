// See https://aka.ms/new-console-template for more information
int numeroEntero;

Console.WriteLine("Ejercicio 1");
Console.WriteLine("Por favor, ingrese un cualquier nùmero entero");

numeroEntero = Convert.ToInt32(Console.ReadLine());

if (numeroEntero > 0)
{
    Console.WriteLine("Numero positivo");
}
else if (numeroEntero < 0)
{
    Console.WriteLine("Nùmero negativo");
}
else
{
    Console.WriteLine("Cero");
}

Console.WriteLine(numeroEntero);