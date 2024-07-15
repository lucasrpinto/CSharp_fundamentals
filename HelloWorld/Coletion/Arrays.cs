/*
Arrays são usados para armazenar coleções de elementos do mesmo tipo em uma única variável, permitindo acesso rápido e eficiente a esses elementos através de índices
 */ 

namespace HelloWorld.Coletion;

public class Arrays
{
    public void ColetionArrays()
    {
        int[] inteiros = new int[10];

        inteiros[0] = 22;
        inteiros[1] = 44;

        Console.WriteLine($"O array tem um espaço de {inteiros.Length}, na posição 0 tem o valor de {inteiros[0]} e na posição 1 tem o valor de {inteiros[1]}");

        // OU

        int[] inteiro = [1, 10];

        Console.WriteLine($"O array tem um espaço de {inteiro.Length}, na posição 0 tem o valor de {inteiro[0]} e na posição 1 tem o valor de {inteiro[1]} ");

        // Definir dimensões para o array

        int[,] dimensao = new int[10, 10];
        dimensao[0, 0] = 1;
        dimensao[0, 3] = 2;

        Console.WriteLine($"Na linha 0, coluna 0 tem o valor de {dimensao[0,0]}, e na linha 1, coluna 1 tem o valor de {dimensao[1,1]}");

    }
}
