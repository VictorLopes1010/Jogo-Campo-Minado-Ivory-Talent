using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chamei uma classe e instanciei o objeto
            chamatabuleiro objeto = new chamatabuleiro();
            objeto.Chama();
            
            //Aqui abro o jogo novamente
            char opcao;
            Console.WriteLine("1 - para jogar novamente");
            Console.WriteLine("0 - para fechar");
            opcao = char.Parse(Console.ReadLine());

            //Função para escolha de fechar ou jogar novamente 
            switch (opcao)
            {
                case '1':
                    objeto.Chama();
                    break;

                case '2':
                    Environment.Exit(0);

                    break;


            }

        }
    }
}







