using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.LacoRepeticao
{
    
    internal class LacoRepeticaoWhile
    {
        // Método sem retorno, dica void
        // Método sem parâmetros, dica n tem variável dentro dos ()
        public void executar()
        {
            int opcaoDesejada = 0;
            while(opcaoDesejada != 8001)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\n1 - Exemplo 01" +
                    "\n2 - Exemplo 02" +
                    "\n3 - Exemplo 03" +
                    "\n8001 - Sair");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                if (opcaoDesejada == 1)
                    Exemplo01();
                else if (opcaoDesejada == 2)
                    Exemplo02();
                else if(opcaoDesejada == 3)
                        Exemplo03();
                else if (opcaoDesejada != 8001)
                    Console.WriteLine("Opção inválida");
            }


            //
            // Link do Miro com os exemplos do prof Francisco https://bit.ly/3nRV19fS
        }
        public void Exemplo01()
        {
            int indice = 0;
            while(indice < 10)
            {
                Console.WriteLine("Oie");
                indice = indice + 1;
            }
            Console.WriteLine("Terminou o exemplo de while");
        }
        public void Exemplo02()
        {
            int indice = 0;
            while (indice < 3)
            {
                // Inputs - entradas

                // Processamento

                // Output
                //Console.WriteLine("Nome completo: " + nomeCompleto);
                //indice = indice + 3;
            }
        }
        /// <summary>
        /// Exemplo pedir para o usuario a quantidade de notas que deseja cadastrar, solicitando-as.
        /// </summary>
        public void Exemplo03()
        {
            //Console.Write("")
            
            int indice = 0;
            //

            while (indice < quantidadeDesejada)
            {
                //Console.Write("Nota")
            }
            double media = somaNotas / quantidadeDesejada;
            // \n é utilizando para quebrar a linha
            //
        }
    }
}
