using System;

public class Forca
{
    private string palavraChave;
    private char[] progresso;
    private int erros = 0;

    public Forca(string palavra)
    {
        palavraChave = palavra;
        progresso = new char[palavra.Length];
        for (int i = 0; i < palavra.Length; i++)
        {
            progresso[i] = '_';
        }
    }

    public void Jogar()
    {
        while (erros < 5 && new string(progresso) != palavraChave)
        {
            Console.WriteLine("Palavra: " + new string(progresso));
            Console.Write("Digite uma letra: ");
            char letra = Console.ReadLine()[0];

            if (palavraChave.Contains(letra.ToString()))
            {
                for (int i = 0; i < palavraChave.Length; i++)
                {
                    if (palavraChave[i] == letra)
                    {
                        progresso[i] = letra;
                    }
                }
            }
            else
            {
                erros++;
                Console.WriteLine("Errou! Total de erros: " + erros);
            }
        }

        if (erros == 5)
        {
            Console.WriteLine("Você perdeu! A palavra era: " + palavraChave);
        }
        else
        {
            Console.WriteLine("Parabéns! Você adivinhou a palavra: " + palavraChave);
        }
    }
}

public class Program
{
    public static void Main()
    {
        Forca jogo = new Forca("casa");
        jogo.Jogar();
    }
}
