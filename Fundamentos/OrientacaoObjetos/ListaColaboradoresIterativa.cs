using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.OrientacaoObjetos
{
    internal class ListaColaboradoresIterativa
    {
        public void CalcularFolhasPagamento()
        {
            FolhaPagamento folhaPagamento = new FolhaPagamento();
            Console.Write("Nome: ");
            folhaPagamento.NomeColaborador = Console.ReadLine().Trim();

        }
    }
}
