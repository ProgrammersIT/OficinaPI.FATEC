using System;

namespace OficinaPI.FATEC
{
    public class Jogador
    {
        public int Opcao { get; private set; }
        
        public Jogador(int opcao)
        {
            
            if (opcao >= 0 && opcao <= 2 )
                Opcao = opcao;
            else
                throw new Exception();
        }
    }
}
