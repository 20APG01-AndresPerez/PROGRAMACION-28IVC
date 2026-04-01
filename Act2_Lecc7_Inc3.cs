using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--MESES--");
        int num;

        Console.WriteLine("Escriba el numero del mes");
        num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
        {
            Console.WriteLine("Enero");
        }
        else if(num ==2) {
            Console.WriteLine("Febrero");
        }
        else if (num == 3)
        {
            Console.WriteLine("Marzo");
        }
        else if (num == 4)
        {
            Console.WriteLine("Abril");
        }
        else if (num == 5)
        {
            Console.WriteLine("Mayo");
        }
        else if (num == 6)
        {
            Console.WriteLine("Junio");
        }
        else if (num == 7)
        {
            Console.WriteLine("Julio");
        }
        else if (num == 8)
        {
            Console.WriteLine("Agosto");
        }
        else if (num == 9)
        {
            Console.WriteLine("Septiembre");
        }
        else if (num == 10)
        {
            Console.WriteLine("Octubre");
        }
        else if (num == 11)
        {
            Console.WriteLine("Noviembre");
        }
        else if (num == 12)
        {
            Console.WriteLine("Diciembre");
        }
        else {
            Console.WriteLine("Opciòn Invalida");
        }
    }

}