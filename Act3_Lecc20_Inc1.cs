internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--DIAS DE LA SEMANA COLOCANDO UN NUMERO DEL 1-7");
        int num;

        Console.Write("Escribir un numero de la semana:  ");
        num = Convert.ToInt32(Console.ReadLine());

        if ((num < 1) || (num > 7))
        {
            Console.WriteLine("No es valido, no es un dia de la semana");
        }
        else if ((num == 1) || (num == 2) || (num == 3) || (num == 4) || (num == 5))
        {
            Console.WriteLine("Entre Semana");
        }
        else
        {
            Console.WriteLine("Fin de Semana");
        }
    }   
}