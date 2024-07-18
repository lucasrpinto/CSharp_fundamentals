namespace HelloWorld.Condicionais;
using HelloWorld;

public class condSwitch
{
    public void switchCond()
    {
        string texto = "Lucas";
        Cor cor = Cor.Roxo;
        int numero = 12;

        string resultado = numero switch
        {
            7  => "Lucas",
            1 => "Rodrigo",
            22 => "Pinto",
            _ => "Nome desconhecido"
        };
        Console.WriteLine(resultado);

        switch (cor)
        {
            case Cor.Azul:
                {
                    Console.WriteLine("Azul");
                }
                break;

            case Cor.Vermelho:
                {
                    Console.WriteLine("Vermelhor");
                }
                break;
            case Cor.Amarelo:
                {
                    Console.WriteLine("Amarelo");
                }
                break;
            default:
                {
                    Console.WriteLine("Nenhuma cor");
                }
                break;
        }
    }


}
