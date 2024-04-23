using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoRa2.Modelo
{
    internal class Validacao
    {
        private string RA = "T915DJ0";
        private string mensagem;
        private string OutroRA;

        public Validacao(string outroRA)
        {
            OutroRA = outroRA;
            Verificar();
        }

        private void Verificar()
        {
            if (RA != OutroRA)
            {
                mensagem = "Esse RA pertence outro aluno!";

            }

            else
            {
                mensagem = "Esse RA pertence a João Vitor da Silva.";
            }
        }

        public string Mensagem { get => mensagem; }

    }
}
