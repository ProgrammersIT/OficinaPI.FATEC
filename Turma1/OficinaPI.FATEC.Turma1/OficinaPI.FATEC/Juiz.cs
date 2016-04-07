namespace OficinaPI.FATEC
{
    public class Juiz
    {
        public Jogador Avaliar(Jogador jogadorUm, Jogador jogadorDois)
        {
            return jogadorUm;
        }

        public bool EstaoEmpatados(Jogador jogadorUm, Jogador jogadorDois)
        {
            return jogadorUm.Opcao == jogadorDois.Opcao;
        }
    }
}
