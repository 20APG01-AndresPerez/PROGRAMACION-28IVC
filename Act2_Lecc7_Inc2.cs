internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--VERFIFICACION DE NOTA");
        string materia;
        int nota;

        Console.Write("Digite una materia");
        materia = Console.ReadLine();
        Console.Write("Escriba la nota");
        nota = Convert.ToInt32(Console.ReadLine());

        if (nota > 50 & nota <= 60)
        {
            Console.WriteLine("Nota Deficiente");
        }
        else if (nota > 61 & nota <= 70){
            Console.WriteLine("Nota regular");
        }
        else if (nota > 71 & nota <= 80)
        {
            Console.WriteLine("Nota Buena");
        }
        else if (nota > 81 & nota <= 90){
            Console.WriteLine("Nota muy buena");
        }
        else if (nota > 91 & nota <= 100)
        {
            Console.WriteLine("Nota excelente");
        }
    }
}