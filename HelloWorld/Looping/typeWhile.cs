namespace HelloWorld.Looping;

public class typeWhile
{
    public void loopingWhile()
    {
        var numero = 0;

        
        while (numero < 5)
        {
            numero++;
            if (numero == 3)
            {
                return;
            }

            Console.WriteLine(numero);

            
        }

        Console.WriteLine("-----------------------------------");



    }

    public string Teste(int numero)
    {
        Console.WriteLine("Teste 1");

        if (numero == 5)
        {
            Console.WriteLine("Teste 2");
            return "Lucas";
        }

        Console.WriteLine("Teste 3");
        return "Pinto";
    }
}
