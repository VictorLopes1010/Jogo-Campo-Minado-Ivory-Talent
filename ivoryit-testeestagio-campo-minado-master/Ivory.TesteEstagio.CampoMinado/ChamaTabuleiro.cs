using System;
using System.Collections.Generic;
using System.Text;

namespace Ivory.TesteEstagio.CampoMinado
{
    class chamatabuleiro : CampoMinado
    {

        public void Chama()
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            //Declarei as variaveis
            int escolhaLinha = 0;
            int escolhaColuna = 0;
            //Aqui peguei o status, e enquanto a o resultado for diferente de 2 ou 1
            while (campoMinado.JogoStatus != 2 && campoMinado.JogoStatus != 1)
            {
                Console.WriteLine(campoMinado.Tabuleiro);
                Console.WriteLine("Digite o valor da Linha");
                escolhaLinha = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor da Coluna");
                escolhaColuna = int.Parse(Console.ReadLine());
                campoMinado.Abrir(escolhaLinha, escolhaColuna);
                Console.Clear();
            }
            //Aqui tratei vitoria/derrota
            if (campoMinado.JogoStatus == 2)
            {
                //Derrota
                Console.WriteLine(campoMinado.Tabuleiro);
                Console.WriteLine("Você perdeu");

            }
            else
            {
                //Vitoria
                Console.WriteLine("Ganhou patrão");
            }

        }
    }
}
