internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--EPOCA DEL AÑO--");
        int dia;
        int mes;

        Console.Write("Pon el día");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("Pon el mes");
        mes = Convert.ToInt32(Console.ReadLine());

        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("Mes no valido");
        }
        else if ((mes == 2 && dia > 28) || ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30) || (dia > 31) || (dia < 1))
        {
            Console.WriteLine("El día ingresado no existe en ese mes");
        }
        else if (mes >= 5 && mes <= 10)
        {
            Console.WriteLine("Es invierno");
        }
        else {
            Console.WriteLine("Es Verano");
        }

    }
}