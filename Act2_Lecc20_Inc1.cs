using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--CONTRASEÑA--");
        string contra;

        Console.Write("Digite la contraseña:  ");
        contra = Console.ReadLine();

        if (contra == "Password123") 
        {
            Console.WriteLine("Bienvenido, tiene acceso a su dispositivo");
        }
        else
        {
            Console.WriteLine("ACCESO DENEGADO");
        }
    }
}