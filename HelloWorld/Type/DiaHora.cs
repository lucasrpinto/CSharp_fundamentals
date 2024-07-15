using System.Globalization;

namespace HelloWorld.Type;

class DiaHora
{
    public void dataHora()
    {
        DateOnly dia = new DateOnly(2023, 12, 1);

        string diaEmTexto = dia.ToString("dd/MMMM,yyyy",new CultureInfo("pt-BR"));

        DateTime dia1 = new DateTime(2024, 07, 11, 16, 31, 0);

        DateTime hoje = DateTime.UtcNow;

        Console.WriteLine(hoje);
    }
}
