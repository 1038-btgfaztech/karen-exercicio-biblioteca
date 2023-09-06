using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro : ItemBiblioteca, IPodeSerEmprestado
    {
        public bool FlagEmprestado = false;
        public DateTime dataEmprestimo = DateTime.Now;
        public Livro(string titulo, string autor, int anoPublicacao, int numeroPaginas) : base(titulo, autor, anoPublicacao, numeroPaginas)
        {
        }

        public void Emprestimo()
        {
            if (FlagEmprestado == false) 
            {
                Console.WriteLine("Emprestando Livro! Data de devolução:" + dataEmprestimo.ToString("dd/MM/yyyy"));
                Informacoes();
                FlagEmprestado = true;
            }
            else
            {
                Console.WriteLine("Este livro encontra-se emprestado até " + dataEmprestimo.AddDays(15).ToString("dd/MM/yyyy"));
                Informacoes();
            }
        }
        public void DevolucaoItem()
        {
            if (FlagEmprestado == true && DateTime.Now > dataEmprestimo.AddDays(15).Date)
            {
                Console.WriteLine("Devolução do livro com atraso. Data estimada para devolução:" + dataEmprestimo.AddDays(15).ToString("dd/MM/yyyy"));
                Informacoes();
            }
            else if (FlagEmprestado == true && DateTime.Now <= dataEmprestimo.AddDays(15).Date)
            {
                Console.WriteLine("Devolução do Livro com sucesso!");
                Informacoes();
            }
            else 
            {
                Console.WriteLine("O livro não encontra-se emprestado.");
                Informacoes();
            }
        }
        
    }
}
