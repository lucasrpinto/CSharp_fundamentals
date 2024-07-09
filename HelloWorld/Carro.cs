namespace HelloWorld;
class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Carro LIGADO");
    }
    public void Desligar()
    {
        Console.WriteLine("Carro DESLIGADO");
    }
    private void Teste1()
    {
        Console.WriteLine("Private Function");
    }
    internal void Teste2()
    {
        // Importanto a Private dentro da Internal para usa-la
        Teste1();
        Console.WriteLine("Internal Function");
    }
}
