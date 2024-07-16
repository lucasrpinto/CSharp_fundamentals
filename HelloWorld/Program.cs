using HelloWorld.Coletion;
using HelloWorld.Funcoes;
using HelloWorld.OtherType;
using HelloWorld.Type;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        int numero = 10;

        var carro = new Carro()
        {
            Modelo = "Porsche",
            LancadoEm = new DateOnly(2021, 01, 01),
            Cor = Cor.Azul

        };

        carro.NomeDoModelo();

        Console.WriteLine("Oi");
    }

   /* static void Main()
    {
        var resultado = OperacoesMatematicas.Adicionar(1, 2);

        Console.WriteLine(resultado);   
    }*/
}


             // Type
/*class Number
{
    static void Main()
    {
        numericos numInt = new numericos();

        numInt.Inteiro();

        numInt.Float();
    }
}*/

/*class Booleano
{
    static void Main ()
    {
        booleanos bolTrueOrFalse = new booleanos();

        bolTrueOrFalse.booleano();
    }
}*/
 
/*class Texto
{
    static void Main ()
    {
        textos texto = new textos ();

        texto.operacaoTexto ();


    }
}*/

/*class dataHora
{
    static void Main()
    {
        DiaHora diaHora = new DiaHora();

        diaHora.dataHora();
    }
}*/

             // OtherType
/*class TypeEnum
{
    static void Main()
    {
        TypeEnums tipoEnum = new TypeEnums();

        tipoEnum.TypeEnum();

    }
}*/

/*class TypeVariable
{
    static void Main()
    {
        TypeVar tipoVar = new TypeVar();
        tipoVar.typeVar();
    }
}*/

             // Coletion
/*class coletionsArray
{
    static void Main()
    {
        Arrays coletionArrays = new Arrays();
        coletionArrays.ColetionArrays();

    }
}*/

/*class coletionListas
{
    static void Main()
    {
        Listas listas = new Listas();
        listas.coletionLista();
    }
}*/

/*class coletionDicionario
{
    static void Main()
    {
        Dicionario dicionario = new Dicionario();
        dicionario.coletionDictionary();
    }
}*/

/*class ColetionHash
{
    static void Main()
    {
        ColetionHashSet coletion = new ColetionHashSet();
        coletion.coletionSet();
    }
}*/

             // Funções
/*class functionMetod
{
    static void Main()
    {
        var matematica = new Funcao();

        var resultado = matematica.Adicionar(7, 1);

        Console.WriteLine(resultado.resultadoDaAdicao);
        Console.WriteLine(resultado.autor);


        var soma = new Funcao();

        soma.Teste(valor1: 2, valor2: 1);
    }
}*/