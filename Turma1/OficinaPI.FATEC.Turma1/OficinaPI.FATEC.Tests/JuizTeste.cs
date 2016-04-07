using NUnit.Framework;

namespace OficinaPI.FATEC.Tests
{
    class JuizTeste
    {
        [Test]
        public void TestaAvaliacao()
        {
            Juiz juiz = new Juiz();

            Jogador jogadorUm = new Jogador(0);
            Jogador jogadorDois = new Jogador(0);

            Jogador vencedor = juiz.Avaliar(jogadorUm, jogadorDois);

            Assert.AreEqual(jogadorUm, vencedor);
        }

        [Test]
        public void TestaEmpate()
        {
            Juiz juiz = new Juiz();

            Jogador jogadorUm = new Jogador(0);
            Jogador jogadorDois = new Jogador(0);

            Assert.True(juiz.EstaoEmpatados(jogadorUm, jogadorDois));
        }
    }
}
