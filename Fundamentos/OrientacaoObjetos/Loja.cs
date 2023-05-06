using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class Loja
    {
        public void Executar()
        {
            // Instanciando um objeto chamado computadorJose da classe Computador
            Computador computadorJose = new Computador();

            Computador computadorCristina = new Computador();
            computadorCristina.Processador = "i5 12300";
            computadorCristina.PlacaVideo = "RXT 4";
            computadorCristina.Preco = "i5 12300";
        }
    }
}
