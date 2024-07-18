namespace HelloWorld.Looping;

public class typeLooping
{
    public void loopingType()
    {
        var lista = new List<string> { "Lucas", "Rodrigo", "Pinto" };
          //Começo   Objetivo     Passos
        for (int i = 0; i < 10; i = i + 2)
        {
            Console.WriteLine(i);
        }
    }
}
