using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaPI.FATEC
{
    public class CaixaEletronico
    {
        public bool ValorValido(int valorSaque)
        {
            if (valorSaque % 10 != 0 )
            {
                return false;
            }else
            {
                return true;
            }
            
        }

        public Notas Sacar(int valorSaque)
        {
            Notas notas = new Notas();
            int resto = valorSaque;
            notas.NotasDe100 = (int)resto/100;
            resto = resto - (100 * notas.NotasDe100);
            notas.NotasDe50 = (int)resto/50;
            resto = resto - (50 * notas.NotasDe50);
            notas.NotasDe20 = (int)resto / 20;
            resto = resto - (20 * notas.NotasDe20);
            notas.NotasDe10 = (int)resto / 10;
            return notas;
        }

    }

}
