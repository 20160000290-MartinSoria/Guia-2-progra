internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("RENGO DE ESTUDIENTES");
        Console.WriteLine("Ingrese una letre de estas: A, B, C, D Y F");
        char letra = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        switch (letra)
        {
            case 'A':
                Console.WriteLine("EXELENTE");
                break;
            case 'B':
                Console.WriteLine("BUENO");
                break;
            case 'C':
                Console.WriteLine("REGULAR");
                break;
            case 'D':
                Console.WriteLine("DEFICIENTE");
                break;
            case 'F':
                Console.WriteLine("REPROBADO");
                break;
            default:
                Console.WriteLine("Escriva una letra valida");
                break;

        }
    }
}