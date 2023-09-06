using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MidiaDigital : ItemBiblioteca, IPodeSerEmprestado
    {
        public MidiaDigital(string titulo, string autor, int anoPublicacao, int numeroPaginas) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
        }

        public void Emprestimo()
        {
            Console.WriteLine("Emprestando Mídia digital permanentemente.");
            Informacoes();
        }
        public void DevolucaoItem()
        {
            Console.WriteLine("Mídia digital não precisa ser devolvida.");
            Informacoes();
        }
    }
}
