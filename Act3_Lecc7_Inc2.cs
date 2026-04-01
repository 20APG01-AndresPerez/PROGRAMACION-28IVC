using System.ComponentModel.Design;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--TRIANGULOS--");
        int a1;
        int a2;
        int a3;

        Console.Write("Ingrese el primer angulo");
        a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el segundo angulo");
        a2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese el tercer angulo");
        a3 = Convert.ToInt32(Console.ReadLine());

        if (a1 + a2 + a3 != 180)
        {
            Console.WriteLine("La suma de sus ángulos no dan 180, No es un triangulo");
        }
        else if ((a1 == 60) && (a2 == 60) && (a3 == 60))
        {
            Console.WriteLine("Es un tiangulo Equilatero");
        }
        else if ((a1 == a2) || (a1 == a3) || (a2 == a3))
        {
            Console.WriteLine("Es un tiangulo Isósceles");
        }
        else {
            Console.WriteLine("Es un triangulo Escaleno");
        }

    }
}