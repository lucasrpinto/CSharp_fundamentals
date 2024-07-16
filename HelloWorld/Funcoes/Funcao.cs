namespace HelloWorld.Funcoes;

public class Funcao
{   
    //public int Adiciontar(int valor1, int valor2) => valor1 + valor2;
    public (int resultadoDaAdicao, string autor) Adicionar (int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        return (resultado, "Lucas");
    }

    public void Teste(int valor1, int valor2 = 7)
    {
        Console.WriteLine (valor1 + valor2);
    }
    
}

public class OperacoesMatematicas
{
    public static int Adicionar(int valor1, int valor2) => valor1 + valor2;
}
