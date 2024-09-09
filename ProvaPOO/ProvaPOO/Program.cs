using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    static class Questao1
    {
        static void Main(string[] args)
        {
            // Solicitar o nome completo do usuário
            Console.WriteLine("Digite o nome completo:");
            string nomeCompleto = Console.ReadLine();

            // Criar objeto da classe NomeProprio
            NomeProprio seunome = new NomeProprio(nomeCompleto);

            // Imprimir o nome no formato "paper"
            Console.WriteLine("Nome no formato acadêmico:");
            seunome.ImprimeNomePaper();

            // Manter o console aberto até uma tecla ser pressionada
            Console.ReadKey();
        }
    }
}
