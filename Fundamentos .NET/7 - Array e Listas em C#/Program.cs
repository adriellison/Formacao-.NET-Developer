public class ArrayEListas
{
    public static void Arrays()
    {
        int[] arrayInteiros = new int[3];

        arrayInteiros[0] = 72;
        arrayInteiros[1] = 64;
        arrayInteiros[2] = 50;

        for (int contador = 0; contador < arrayInteiros.Length; contador++)
        {
            Console.WriteLine($"Posição N* {contador} - {arrayInteiros[contador]}");
        }

        foreach (int valor in arrayInteiros)
        {
            Console.WriteLine(valor);
        }
    }

    public static void Lists()
    {
        List<string> listaString = new List<string>();

        listaString = ["SP", "BA", "MG"];

        listaString.Add("RJ");
        listaString.Add("SC");
        listaString.Add("PR");
        listaString.Add("RS");

        for (int contador = 0; contador < listaString.Count; contador++)
        {
            Console.WriteLine($"Posição N* {contador} - {listaString[contador]}");
        }

        foreach (string estado in listaString)
        {
            Console.WriteLine(estado);
        }

        listaString.Remove("MG");
        Console.WriteLine("Após a remoção:");

        foreach (string estado in listaString)
        {
            Console.WriteLine(estado);
        }

        Console.WriteLine($"Total de elementos na lista: {listaString.Count}");
        Console.WriteLine($"A lista contém o estado SC? {listaString.Contains("SC")}");
    }
}