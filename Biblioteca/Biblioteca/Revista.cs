using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : ItemBiblioteca, IPodeSerEmprestado
    {
        public bool FlagEmprestado = false;
        public Revista(string titulo, string autor, int anoPublicacao, int numeroPaginas) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
        }

        public void Emprestimo()
        {
            if (FlagEmprestado)
            {
                Console.WriteLine("Emprestando Revista!");
                Informacoes();
                FlagEmprestado = true;
            }
            else
            {
                Console.WriteLine("Esta revista encontra-se emprestada!");
                Informacoes();
            }
        }
        public void DevolucaoItem()
        {
            if (!FlagEmprestado)
            {
                Console.WriteLine("Devolução da revista com sucesso!");
                Informacoes();
            }
            else
            {
                Console.WriteLine("A revista não encontra-se emprestado.");
                Informacoes();
            }
        }
    }
}
