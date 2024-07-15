namespace HelloWorld.Coletion;

public class Listas
{
    public void coletionLista()
    {
        List<int> inteiros = new List<int>();

            inteiros.Add(1);  // index 0  
            inteiros.Add(22); // index 1
            inteiros.Add(99); // index 2
            inteiros.Add(24); // index 3

            int primeiroElmento = inteiros.First();
            int ultimoElemento = inteiros.Last();

            // Para remover
            // inteiros.Clear(); excluir todos os elmentos da lista
            // inteiros.Remove(24);
            inteiros.RemoveAt(3);

            Console.WriteLine($"A lista tem um tamanho de {inteiros.Count}. Na primeira posição tem o valor de {primeiroElmento} e a ultima posição de {ultimoElemento}, o index número 2 tem o valor de {inteiros.ElementAt(2)}");

        List<object> objetos = new List<object>();

            objetos.Add(1);
            objetos.Add(1.5f);
            objetos.Add("Hello");
            objetos.Add(true);

            var elementFirst = objetos.First();
            var elementLast = objetos.Last();

            Console.WriteLine($"A Lista tem {objetos.Count} espaços. A primeira posição tem o valor de {elementFirst} e o ultimo elemento e de valor {elementLast}. Na posição 2 tem o valor de {objetos.ElementAt(1)} e na posição 3 tem o valor {objetos.ElementAt(2)}");

        string resultado = string.Join(" ;", objetos);

        Console.WriteLine(resultado);   

    }
}
