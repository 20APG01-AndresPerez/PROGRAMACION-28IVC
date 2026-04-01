internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--BUZON DE VOZ--");
        int num;

        Console.Write("Presione un numero del 1-4: 1. Ventas ,2. Soporte Técnico, 3. Contabilidad,4. Hablar con el gerente");
        num= Convert.ToInt32(Console.ReadLine());

        if (num==1){
            Console.WriteLine("Ventas");
        }
        else if (num==2){
            Console.WriteLine("Soporte Tècnico");
        }
        else if (num==3){
            Console.WriteLine("Contabilidad");
        }
        else if (num==4){
            Console.WriteLine("Hablar con el gerente");
        }
        else {
            Console.WriteLine("Opciòn Invàlida");
        }
    }
}