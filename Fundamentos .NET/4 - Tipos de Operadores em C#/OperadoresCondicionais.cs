public static class OperadoresCondicionais
{
    public static void VerioficacaoDeEstoque()
    {
        int estoque = 10;
        int venda = 9;
        
        bool possivelVender = PossivelVender(estoque, venda);

        RetornoDoSistema(estoque, venda);
    }

    public static bool PossivelVender(int estoque, int venda)
    {
        if(venda <= 0)
            throw new Exception("Não foi informado uma quantidade valida para venda!");

        if(venda <= estoque)
            return true;

        return false;
    }

    public static void RetornoDoSistema(int quantidadeEmEstoque, int quantidadeParaVenda)
    {
        Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
        Console.WriteLine($"Quantidade para venda: {quantidadeParaVenda}");
    }
}