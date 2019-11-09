using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex004
{
    public class Usuario
    {
        public int ExibirNiveisDeJogo()
        {
            int opcaoEscolhida = 0;

            Console.WriteLine("==================================");
            Console.WriteLine("Digite 1 ou 2 de acordo o nível de jogo que gostaria de jogar:");
            Console.WriteLine
                (
                    $" Nível 1 (10 chances para acertar)\n " +
                    $" Nível 2 (5 chances para acertar)"
                );
            Console.WriteLine("==================================");

            opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
            return opcaoEscolhida;
        }
        public char InformarUmaLetra()
        {
            char letra;
            Console.Write("Escolha uma letra: ");
            letra = char.Parse(Console.ReadLine());
            return letra;
        }

        public void InformarLetraEncontrada()
        {
            Console.WriteLine("Parabéns! A letra informada existe na palavra");
        }

        public void InformarPalavraAtualizada(string[] animalAtualizado)
        {
            Console.WriteLine(string.Join(" ", animalAtualizado));
        }

        public void InformarLetraNaoEncontrada()
        {
            Console.WriteLine("Que pena! A letra informada não existe na palavra");
        }

        public void InformarTentativasRestantes(int tentativasRestantes)
        {
            Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
        }

    }
}
