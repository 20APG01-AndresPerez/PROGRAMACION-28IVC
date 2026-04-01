internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--VERIFICACIÓN DE MAYORÍA DE EDAD--");
        int edad;

        //Enviar informacion al usuario
        Console.Write("Ingrese su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        //Proceso de verificación
        if (edad > 18) {
            Console.WriteLine("Usted es mayor de edad.");

        }
        else {
            Console.WriteLine("Usted es menor de edad.");
        }
    }
}