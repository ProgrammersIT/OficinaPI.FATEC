using NUnit.Framework;
using System;

namespace OficinaPI.FATEC.Tests
{
    [TestFixture]
    public class JogadorTeste
    {
        [Test]
        public void TestJogadorIniciaComOpcao()
        {
            Jogador jogador = new Jogador(5);

            Assert.AreEqual(5, jogador.Opcao);
        }

        [Test]
        public void TestaSeOpcaoEhValida()
        {
           Assert.Throws<Exception>(()=> new Jogador(4));
        }
    }
}
