public class TiposDeOperadores
{
    // OPERADORES DE ATRIBUIÇÃO

    // int a = 10;
    // int b = 20;

    // int c = a + b;

    // c = c + 5;  30 + 5 = 35


    // COMBINANDO OPERADORES

    //c += 5; 30 + 5 = 35

    // c *= 5; // 30 * 5 = 150

    // Cast - casting
    // int a = Convert.ToInt32("5");
    // Console.WriteLine(a);

    // int b = int.Parse("5");
    // Console.WriteLine(b);


    // DIFERENÇA ENTRE CONVERT E PARSE

    // int c = Convert.ToInt32(null); // Converte null retorna 0 continuando a execução
    // Console.WriteLine(c);

    // int d = int.Parse(null); // Parse não aceita null e retorna uma exceção em seguida para a execução
    // Console.WriteLine(d);


    // CONVERSÃO PARA STRING

    // int inteiro = 5;

    // string a = inteiro.ToString();

    // Console.WriteLine(a);
    // Todo tipo pode ser representado em string e convertido para string com .ToString()

    public static void CastImplicito()
    {
        // CAST IMPLÍCITO
        int a = 5;
        double b = a;

        Console.WriteLine(b);

        double c = 5;
        int d = Convert.ToInt32(c);

        Console.WriteLine(c);
    }

    public static void OrdemDosOperadores()
    {
        // ORDEM DOS OPERADORES
        double a = 4 / 2 + 2; // = 4
        double b = 4 / (2 + 2); // = 1

        Console.WriteLine("a = ", a, "b = ", b);
    }

    public static void Conversao()
    {
        string a = "15-";

        int b = 0;

        int.TryParse(a, out b); // TryParse já espera que va da erro
                                // Tenta converter, se não der ele exibe o b

        Console.WriteLine(b);
        Console.WriteLine("Conversão realizada com sucesso!");
    }
}