using System.Text;

namespace HelloWorld.Type;

class textos
{
    /*public void texto()
    {
         // Variáveis do tipo TEXTO
         // char (Sómente um caracter (Tem que esta entre aspas simples))
         // String (Frases ou palavras (aspas duplas))

        char letra = 'a';
        char numero = '1';
        char caracter = '@';

        string texto = "Este curso é muito bom!";
        
         // Para acessar a primeira letra do texto
        char primeiraLetraDoTexto = texto[0];

        string meuNome = "          Lucas         ";

         // Trim para remover espaço do meio e do fim
        string meuNomeSemEspaco = meuNome.Trim();

         // Troca um caracter por outro
        string textoReplace = meuNomeSemEspaco.Replace('a', '4');

         // StartsWith verifica se começa com a informação selecionada
        bool comecaComL = meuNomeSemEspaco.StartsWith("L");
        bool terminaComL = meuNomeSemEspaco.EndsWith("L");

         // Verifica se contém
        bool existe = texto.Contains("curso");
         // Verifica se é igual (identico) 
        bool igual = texto.Equals("Este curso é muito bom!");



        Console.WriteLine("Trocando caracter " + textoReplace);

        Console.WriteLine("A frase começa com L? " + comecaComL);
        Console.WriteLine("A frase termina com L? " + terminaComL);

        Console.WriteLine(meuNome);
        Console.WriteLine(meuNomeSemEspaco);

        Console.WriteLine( texto );
        Console.WriteLine( "A primeira letra do texto é... " + primeiraLetraDoTexto ); 
        Console.WriteLine( "Exite a palavra curso? " + existe );
        Console.WriteLine( "O texto é igual? " + igual );

    }*/

    public void operacaoTexto()
    {
        string texto1 = "A primeira frase. ";
        string texto2 = "Segunda Frase";

         // @ usado para colcoar caminhos do Sistema operacional
        string caminho = @"C:\teste\teste1\teste2";
        string paragrafo = texto1 + texto2;

         // $ usado na String para colocar valores que não são String
        string paragrafo2 = $"A primeira frase. {7} {caminho} segunda frase";

         // Forma usada para concatenar Strings com variaveis
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(paragrafo);
        stringBuilder.Append(paragrafo2);

        string restultado = stringBuilder.ToString();

         // Fixar string e definir paramêtros para ela
        string texto = "O usuario {0} gosta do número {1}";
        string resultado2 = string.Format(texto, "Lucas", 7);

        Console.WriteLine(resultado2);

        Console.WriteLine(restultado);

        Console.WriteLine(paragrafo);
        Console.WriteLine(caminho);
         
        Console.WriteLine(paragrafo2);
    }
}
