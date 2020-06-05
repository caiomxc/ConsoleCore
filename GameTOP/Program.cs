using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador2(),
                new Jogador2()
            );
            jogo.IniciarJogo();
        }
    }
 
}
