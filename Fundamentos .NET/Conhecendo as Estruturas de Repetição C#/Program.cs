public class Program
{
    public static void Main()
    {
        int numero = 10;

        for(int contador = 0; contador <= 10; contador++)
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    }
}