using System;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---------- Jogo de Adivinhar ------------");
         
            int tentativas = 0;
            char respostaUsuario = 'S';
           
             do {

                float sorteio = new Random().Next(0, 20);
                Console.WriteLine(" ");
                Console.WriteLine("digite um numero: ");
                float numeroUsuario = float.Parse(Console.ReadLine());

                if (numeroUsuario == sorteio)
                {
                    Console.WriteLine("você acertou o numero é: " + sorteio);
                    tentativas = 5;
                    Console.WriteLine("-----------------------------------------");
                }
                else
                {
                    Console.WriteLine($"voce errou, tente novamente");
                    tentativas++;
                    Console.WriteLine("{0} de 5 chances. ", tentativas);
                    if (numeroUsuario == sorteio + 1  || numeroUsuario == sorteio - 1)
                    {
                        Console.WriteLine($"Você chegou muito perto, o numero era {sorteio}");
                        Console.WriteLine("-----------------------------------------");
                    }
                    else if (numeroUsuario == sorteio + 5 || numeroUsuario == sorteio - 5)
                    {
                        Console.WriteLine($"Você chegou perto, o numero era {sorteio}");
                        Console.WriteLine("-----------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine($"Você não chegou perto, o numero era {sorteio}");
                        Console.WriteLine("-----------------------------------------");
                    }

                    Console.WriteLine("Deseja continuar?[S/N]");
                    respostaUsuario = char.Parse(Console.ReadLine().ToUpper());
                    
                }

            } while(tentativas < 5 && respostaUsuario == 'S');
        }
     }
}
