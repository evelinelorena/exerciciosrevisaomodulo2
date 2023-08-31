using ExercicioRevisao1;

internal class Program
{
    private static void Main(string[] args)
    {
        Empresa varejo = new Varejo();
        varejo.Nome = "Varejão Supermercados";
        varejo.CNPJ = "78.357.753/0001-12";
        varejo.ImprimirInformacoesEmpresa();
        varejo.RealizarVenda();

        Empresa empreiteira = new Empreiteira();
        empreiteira.Nome = "Construção Mais";
        empreiteira.CNPJ = "55.357.753/0001-12";
        empreiteira.ImprimirInformacoesEmpresa();
        empreiteira.RealizarVenda();

    }
}