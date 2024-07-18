namespace HelloWorld.Condicionais;
using HelloWorld;

public class condIf
{
    public void typeIf ()
    {
        int numero = 0;
        double saldo = 100.50;
        bool ativo = true;
        string autor = "Lucas";
        List<int> lista = new List<int>{1, 7};
        Cor cor = Cor.Azul;

       /* //IF / ELSE IF / ELSE
        * 
        * // INT
        if (numero > 18)
        {
            Console.WriteLine("Tem mais de 18 anos");
            if (autor.Equals("Lucas"))
            {
                Console.WriteLine($"Usuário {autor} autorizado");
            }
        }
        else if (numero == 18)
        {
            Console.WriteLine($"Tem {numero} anos");
        }
        else
        {
            Console.WriteLine("É menor de idade");
        }

        // String
        if (!autor.Equals("Luca"))
        {
            Console.WriteLine("Usuário não cadastrado");
        }

        // Lista
        if (lista.Contains(7))
        {
            Console.WriteLine("Acessou");
        }

        //Enum
        if (cor != Cor.Vermelho)
        {
            Console.WriteLine("Escolheu cor certa");
        }*/

       /* if (cor == Cor.Azul || numero > 0)
        {
            Console.WriteLine("ACESSOU");
        }*/
        

        // IF Ternário
        string menssagemErro = null;

        int number = 12;

        //              IF      ENTÃO      ELSE
        string name = numero == 7 ? "Lucas" : "Não Lucas";

        Console.WriteLine(name);
    }

}
