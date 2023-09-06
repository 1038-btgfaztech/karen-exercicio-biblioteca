using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {
        public List<ItemBiblioteca> itens = new();

        public void EmprestimoItens(ItemBiblioteca item)
        {
            IPodeSerEmprestado emprestavel = (IPodeSerEmprestado) item;
            emprestavel.Emprestimo();
        }
        public void DevolucaoItens(ItemBiblioteca item)
        {
            IPodeSerEmprestado emprestavel = (IPodeSerEmprestado)item;
            emprestavel.DevolucaoItem();
        }

        public void Adicionar(ItemBiblioteca item) 
        {
            itens.Add(item);
        }
    }
}
