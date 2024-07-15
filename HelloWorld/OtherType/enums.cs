namespace HelloWorld.OtherType;

class TypeEnums
{
    enum NivelDeDificulade
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2
    }
    public void TypeEnum()
    {
        NivelDeDificulade nivel = NivelDeDificulade.Alto;

        int nivelInteiro = (int)nivel;

        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);
    }
}
