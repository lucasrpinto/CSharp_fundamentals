namespace HelloWorld.OtherType;

public class TypeVar
{
    public void typeVar()
    {
        string nome = "Lucas";
        int? nascimento = null;

        int dataNascimento = nascimento.Value;

        var now = DateTime.Now;
        var anoAtual = now.Year;

        var idade = anoAtual - nascimento;

        if (idade > 18)
        {
            Console.WriteLine($"Tem {idade} anos, pode comprar bebida!");
        } else
          {
            Console.WriteLine($"tem {idade} anos, não pode comprar bebida!");      
          }
    }
}
