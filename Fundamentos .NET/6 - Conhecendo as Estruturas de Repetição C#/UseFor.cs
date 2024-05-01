public class UseFor
{
    public static void UsandoFor(bool runMethod = false)
    {
        if (!runMethod)
            return;

        int numero = 10;

        for (int contador = 0; contador <= 10; contador++)
            Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    }
}