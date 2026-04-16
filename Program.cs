internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escriba dos volores numericos");
        double num1 = Convert.ToDouble(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n***MENU PRENCIPAL**");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Divicion");
        Console.WriteLine("5. Salir");
        Console.WriteLine("Dijite el Valor segun la operacion: []");
        int opc = Convert.ToInt32(Console.ReadLine());

        //Evaluar con swith
        string mjs = "";
        double result = 0;
        switch (opc)
        {
            case 1:
                mjs = "\nSUMA \nLa suma es: " + (num1 + num2);
                break;
            case 2:
                mjs = "\nRESTA \nLa resta es: " + (num1 - num2);
                break;
            case 3:
                mjs = "\nMULTIPLICACION \nLa multiplicacion es: " + (num1 * num2);
                break;
            case 4:
                mjs = "\nDIVICION \nLa divicion es: " + (num1 / num2);
                break;
            case 5:
                mjs = "Saliendo del sistema!!!";
                break;
            default:
                mjs = "Dijite  una Opcion valida";
                break;

        }
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mjs);
        Console.WriteLine(result);
    }
}