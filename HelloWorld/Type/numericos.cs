namespace HelloWorld.Type;

class numericos
{
    public void Inteiro()
    {
        // Números inteiros
        int inteiro = 7;
        long inteiro2 = 7;

        Console.WriteLine(inteiro);

    }

    public void Float()
    {
        //Números flutuantes
        double flutuante = 3.14;

        // Utiliza o F no final para converter o double em float
        float flutuante2 = 0.14f;

        // Utiliza o M no final para converter o double em decimal
        decimal flutuante3 = 3.14m;

        Console.WriteLine(flutuante);

        Console.WriteLine(flutuante2);
    }
}
