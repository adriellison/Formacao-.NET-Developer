public class OperadoresLogicos
{
    public static void VerificacaoDeNota()
    {
        double nota1, nota2;
        nota1 = 2.5;
        nota2 = 8;
        int frequencia = 70;

        bool verificarMedia = VerificarMedia(nota1, nota2);
        bool verificarPresenca = VerificarPresenca(frequencia);

        if (verificarMedia && verificarPresenca)
            Console.WriteLine($"😁🎉 Aprovado!");
        else
            Console.WriteLine($"😔🍃 Reprovado!");
    }

    public static bool VerificarMedia(double nota1, double nota2){
        double media = (nota1 + nota2) / 2;
        return media > 6;
    }
    
    public static bool VerificarPresenca(int frequencia)
    {
        return (frequencia >= 70);
    }
}