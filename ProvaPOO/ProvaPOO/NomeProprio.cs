using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class NomeProprio
    {
        public string NomeCompleto { get; private set; }
        public string NomePaper { get; private set; }

        // Construtor que recebe o nome completo
        public NomeProprio(string nomeCompleto)
        {
            NomeCompleto = nomeCompleto;
            GerarNomePaper();
        }

        // Método que gera o nome no formato "Sobrenome, Primeiro Nome e Inicial do Nome do Meio"
        private void GerarNomePaper()
        {
            string[] partesNome = NomeCompleto.Split(' ');

            if (partesNome.Length >= 2)
            {
                string primeiroNome = partesNome[0];
                string sobrenome = partesNome[partesNome.Length - 1];
                string nomeDoMeio = partesNome.Length > 2 ? partesNome[1][0] + "." : "";

                NomePaper = $"{sobrenome}, {primeiroNome} {nomeDoMeio}";
            }
            else
            {
                // Caso o nome seja composto por apenas uma parte
                NomePaper = NomeCompleto;
            }
        }

        // Método que imprime o nome no formato "paper"
        public void ImprimeNomePaper()
        {
            Console.WriteLine(NomePaper);
        }
    }
}