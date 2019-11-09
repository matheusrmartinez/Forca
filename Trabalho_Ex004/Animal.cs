using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Ex004
{
    public class Animal
    {
        Usuario interacoesUsuario = new Usuario();
        public string Nome { get; set; }

        public string SortearAnimal(List<string> animais)
        {
            string animalSorteado;
            int index;
            var random = new Random();

            index = random.Next(animais.Count + 1);
            animalSorteado = animais[index];

            return animalSorteado;
        }

        public void ForcaAnimal(string animalSorteado, int nivelEscolhido)
        {
            int contadorDeLetras = 0;
            char letraEscolhida, letraUpper;
            string letraEscolhida_;

            foreach (var letra in animalSorteado)
            {
                contadorDeLetras++;
            }

            string[] arrayAnimal = new string[contadorDeLetras];

            for (int i = 0; i < arrayAnimal.Length; i++)
            {
                arrayAnimal[i] = "_";
            }

            interacoesUsuario.InformarPalavraAtualizada(arrayAnimal);

            switch (nivelEscolhido)
            {

                #region Nível 1
                case 1:
                    int tentativas = 10;

                    while (tentativas > 0)
                    {
                        letraEscolhida = interacoesUsuario.InformarUmaLetra();
                        letraEscolhida_ = letraEscolhida.ToString().ToUpper();
                        letraUpper = char.Parse(letraEscolhida_);

                        int index = 0, count = 0;

                        foreach (var letra in animalSorteado)
                        {
                            string letra_;
                            char letraUpper_;

                            letra_ = letra.ToString().ToUpper();
                            letraUpper_ = char.Parse(letra_);

                            if (letraUpper_ == letraUpper)
                            {
                                arrayAnimal[index] = letraEscolhida.ToString();
                                if (count == 0)
                                    interacoesUsuario.InformarLetraEncontrada();
                                count++;
                            }
                            index++;
                        }
                        if (count == 0)
                            interacoesUsuario.InformarLetraNaoEncontrada();

                        interacoesUsuario.InformarPalavraAtualizada(arrayAnimal);
                        tentativas--;
                        interacoesUsuario.InformarTentativasRestantes(tentativas);
                    }
                    break;

                #endregion

                #region Nível 2
                case 2:
                    int tentativas_ = 5;

                    while (tentativas_ > 0)
                    {
                        letraEscolhida = interacoesUsuario.InformarUmaLetra();
                        letraEscolhida_ = letraEscolhida.ToString().ToUpper();
                        letraUpper = char.Parse(letraEscolhida_);

                        int index = 0, count = 0;

                        foreach (var letra in animalSorteado)
                        {
                            string letra_;
                            char letraUpper_;

                            letra_ = letra.ToString().ToUpper();
                            letraUpper_ = char.Parse(letra_);

                            if (letraUpper_ == letraUpper)
                            {
                                arrayAnimal[index] = letraEscolhida.ToString();
                                if (count == 0)
                                    interacoesUsuario.InformarLetraEncontrada();
                                count++;
                            }
                            index++;
                        }
                        if (count == 0)
                            interacoesUsuario.InformarLetraNaoEncontrada();

                        interacoesUsuario.InformarPalavraAtualizada(arrayAnimal);
                        tentativas_--;
                        interacoesUsuario.InformarTentativasRestantes(tentativas_);
                    }
                    break;

                    #endregion
            }
        }
    }
}
