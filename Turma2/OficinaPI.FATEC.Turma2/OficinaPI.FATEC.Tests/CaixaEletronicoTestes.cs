using NUnit.Framework;

namespace OficinaPI.FATEC.Tests
{
    [TestFixture]
    public class CaixaEletronicoTestes
    {
        [Test]
        public void Verifica_se_valor_nao_esta_disponivel()
        {
            int valorSaque = 75;
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Assert.AreEqual(caixaEletronico.ValorValido(valorSaque), false);
            

        }

        [Test]
        public void Verificar_se_valor_esta_disponivel()
        {
            int valorSaque2 = 80;
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Assert.AreEqual(caixaEletronico.ValorValido(valorSaque2), true);
        }
        [Test]
        public void Verificar_Quantidade_de_Notas()
        {
            int valorSaque = 250;
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Notas notas = caixaEletronico.Sacar(valorSaque);
            Assert.AreEqual(2, notas.NotasDe100);
            Assert.AreEqual(1, notas.NotasDe50);
        }
        [Test]
        public void Sacar_350_retorna_3x100_e_1x50()
        {
            int valorSaque = 350;
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Notas notas = caixaEletronico.Sacar(valorSaque);
            Assert.AreEqual(3, notas.NotasDe100);
            Assert.AreEqual(1, notas.NotasDe50);
        }

        [Test]
        public void Sacar_390_retorna_3x100_e_1x50_e_2x20()
        {
            int valorSaque = 390;
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Notas notas = caixaEletronico.Sacar(valorSaque);
            Assert.AreEqual(3, notas.NotasDe100);
            Assert.AreEqual(1, notas.NotasDe50);
            Assert.AreEqual(2, notas.NotasDe20);
        }
        [Test]
        public void Sacar_410_retorna_4x100_e_1x10()
        {
            int valorSaque = 410;
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Notas notas = caixaEletronico.Sacar(valorSaque);
            Assert.AreEqual(4, notas.NotasDe100);
            Assert.AreEqual(1, notas.NotasDe10);
        }
        [Test]
        public void Sacar_380_retorna_3x100_e_1x50_e_1x20_1x10()
        {
            int valorSaque = 380;
            CaixaEletronico caixaEletronico = new CaixaEletronico();
            Notas notas = caixaEletronico.Sacar(valorSaque);
            Assert.AreEqual(3, notas.NotasDe100);
            Assert.AreEqual(1, notas.NotasDe50);
            Assert.AreEqual(1, notas.NotasDe20);
            Assert.AreEqual(1, notas.NotasDe10);
        }
    }

}
