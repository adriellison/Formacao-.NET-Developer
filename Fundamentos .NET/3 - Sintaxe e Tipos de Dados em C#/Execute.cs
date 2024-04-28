using Model;

public class Execute
{
    public static void Main()
    {
        Pessoa pessoa1 = new Pessoa();

        pessoa1.Nome = "Ana";
        pessoa1.Idade = 23;
        pessoa1.Apresentar();
    }
}