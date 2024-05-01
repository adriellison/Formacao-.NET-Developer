public class UseDoWhile
{
    public static void UsandoDoWhile(bool runMethod = false)
    {
        if (!runMethod)
            return;

        Console.WriteLine("Hello, World!");

        bool flag = true;
        int contador = 0;
        do
        {
            contador++;

            if (contador == 5)
                flag = false;
        } while (flag);
    }
}