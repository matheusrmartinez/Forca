using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            int nivelEscolhido = 0;
            Animal animal = new Animal();
            Usuario interacoesUsuario = new Usuario();
            string animalSorteado;
            List<string> animais = new List<string>
            {
                "Girafa",
                "Elefante",
                "Lobo",
                "Coelho",
                "Pinguim",
                "Leao"
            };

            animalSorteado = animal.SortearAnimal(animais);
            nivelEscolhido = interacoesUsuario.ExibirNiveisDeJogo();
            animal.ForcaAnimal(animalSorteado, nivelEscolhido);
        }
    }
}
