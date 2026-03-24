using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("==PROMEDIO DE CALIFICACIONES==");
        //Variables
        string materia;
        int n1, n2, n3, n4, n5;
        double promedio;

        //Enviar informacion al usuario
        Console.Write("Digite una materia");
        materia = Console.ReadLine();
        Console.Write("Dame 5 notas: ");
        n1= Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());
        n4 = Convert.ToInt32(Console.ReadLine());
        n5 = Convert.ToInt32(Console.ReadLine());

        //Proceso
        promedio = (n1+n2+n3+n4+n5)/5;

        //Evaluar si gano o pérdio
        if (promedio >= 70)
            Console.WriteLine("El promedio es :" +promedio+ "y el estudiamte aprobó");
        else
            Console.WriteLine("El promedio es: "  + promedio +  "y el estudiante Reprobó");
    }
}