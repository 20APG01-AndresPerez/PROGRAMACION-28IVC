internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--DIAS DE LA SEMANA--");
        int num;

        Console.Write("Digite un numero del 1-7:  ");
        num= Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            Console.WriteLine("Hoy es Lunes");
        }
        else if (num == 2) {
            Console.WriteLine("Hoy es Martes");
        }
        else if (num == 3)
        {
            Console.WriteLine("Hoy es Miercoles");
        }
        else if (num == 4)
        {
            Console.WriteLine("Hoy es Jueves");
        }
        else if (num == 5)
        {
            Console.WriteLine("Hoy es Viernes");
        }
        else if (num == 6)
        {
            Console.WriteLine("Hoy es Sabado");
        }
        else if (num == 7)
        {
            Console.WriteLine("Hoy es Domingo");
        }
        else
        {
            Console.WriteLine("No es un dia de la semana");
        }
    }
}