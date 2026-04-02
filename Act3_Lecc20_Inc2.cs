internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--CALCULAR SI EL ALUMNO GANA O PIERDE--");
        int nota;

        Console.Write("Escriba la nota:  ");
        nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 70)
        {
            Console.WriteLine("Usted Aprobó el curso");
        }
        else
        {
            Console.WriteLine("Usted Reprobó el curso");
        }
    }
}