using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  abstract class ItemBiblioteca
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public int NumeroPaginas { get; set; }

        protected ItemBiblioteca(string titulo, string autor, int anoPublicacao, int numeroPaginas)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
            NumeroPaginas = numeroPaginas;
        }

        public virtual void Informacoes()
        {
            Console.WriteLine($"Informações:{Environment.NewLine}" +
                $"Titulo: {Titulo}{Environment.NewLine}" +
                $"Autor: {Autor}{Environment.NewLine}" +
                $"Ano: {AnoPublicacao}{Environment.NewLine}" +
                $"Páginas: {NumeroPaginas}{Environment.NewLine}");
        }

    }
}
