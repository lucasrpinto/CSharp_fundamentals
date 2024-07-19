namespace HelloWorld.Looping;

public class typeLooping
{
    public void loopingType()
    {
        var lista = new List<string> { "Lucas", "Rodrigo", "Pinto" };
        var dicionario = new Dictionary<string, string>();

        dicionario.Add("Nome1", "Lucas");
        dicionario.Add("Nome2", "Rodrigo");
        dicionario.Add("Nome3", "Pinto");
        
          //Começo   Objetivo     Passos
        for (int i = 0; i < 10; i = i + 2)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("----------------------");

        foreach (var item in dicionario)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }
    }
}
