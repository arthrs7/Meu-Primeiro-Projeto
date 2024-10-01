using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vamos jogar Pedra, Papel e Tesoura!");

        Console.WriteLine("Digite 1 para Papel, 2 para Tesoura, 3 para Pedra:");
        int jogadorEscolha = int.Parse(Console.ReadLine());

        Random random = new Random();
        int computadorEscolha = random.Next(1, 4);

        Console.WriteLine($"Você escolheu: {jogadorEscolha}");
        Console.WriteLine($"O computador escolheu: {computadorEscolha}");

        if (jogadorEscolha == computadorEscolha)
        {
            Console.WriteLine("Empate!");
        }
        else if ((jogadorEscolha == 1 && computadorEscolha == 3) ||
                 (jogadorEscolha == 2 && computadorEscolha == 1) ||
                 (jogadorEscolha == 3 && computadorEscolha == 2))
        {
            Console.WriteLine("Você ganhou!");
        }
        else
        {
            Console.WriteLine("Você perdeu!");
        }
    }
}
