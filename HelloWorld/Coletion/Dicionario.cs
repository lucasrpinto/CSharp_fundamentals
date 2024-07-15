namespace HelloWorld.Coletion;

public class Dicionario
{
    public void coletionDictionary()
    {
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        dicionario.Add(1, "Lucas");
        dicionario.Add(2, "Rodrigo");
        dicionario.Add(7, "Pinto");

        string value = dicionario[1];
          

        bool existe = dicionario.ContainsKey(3);

        if (existe == true)
        {
            Console.WriteLine("Usuário Cadastrado!");
        } else
        {
            Console.WriteLine("Usuário não encontrado!");
        }
    }
}
