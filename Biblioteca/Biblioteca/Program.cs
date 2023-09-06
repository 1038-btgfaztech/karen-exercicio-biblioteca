namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Imagine um sistema de gerenciamento de uma biblioteca. Neste sistema, você deve usar classes abstratas e interfaces para modelar diferentes tipos de itens da biblioteca, como livros, revistas e mídias digitais (por exemplo, e-books).

                1. Crie uma classe abstrata chamada "ItemBiblioteca" que contenha informações comuns a todos os itens, como título, autor, ano de publicação e número de páginas.

                2. Defina uma interface chamada "PodeSerEmprestado" que declare métodos para empréstimo e devolução de itens.

                3. Crie classes concretas para representar diferentes tipos de itens da biblioteca, como "Livro", "Revista" e "MidiaDigital". Essas classes devem herdar da classe abstrata "ItemBiblioteca" e implementar a interface "PodeSerEmprestado" se aplicável (você pode decidir que tipos de itens serão emprestáveis).

                4. Implemente os métodos de empréstimo e devolução de acordo com a natureza do item. Por exemplo, um livro pode ser emprestado por um período definido, enquanto uma mídia digital pode ser emprestada indefinidamente.

                5. Crie uma classe chamada "Biblioteca" que gerencie uma coleção de itens da biblioteca e forneça métodos para emprestar e devolver itens.

                6. Crie instâncias de diferentes tipos de itens da biblioteca e demonstre como eles podem ser emprestados e devolvidos usando a classe "Biblioteca".

                Crie um repositório no GitHub da organização da turma e submeta o link do  formulário que será enviado neste canal hoje à tarde.*/


            Biblioteca biblioteca = new Biblioteca();

            Livro livro = new Livro("Clean code", "Robert C. Martin", 2011, 423);
            biblioteca.Adicionar(livro);
            biblioteca.EmprestimoItens(livro);
            biblioteca.DevolucaoItens(livro);


            Revista revista = new Revista("Revista x", "Autor x", 2023, 8);
            biblioteca.Adicionar(revista);
            biblioteca.EmprestimoItens(revista);
            biblioteca.DevolucaoItens(revista);

            MidiaDigital midiaDigital = new MidiaDigital("Ebook z", "Autor z", 2023, 5);
            biblioteca.Adicionar(midiaDigital);
            biblioteca.EmprestimoItens(midiaDigital);
            biblioteca.DevolucaoItens(midiaDigital);

        }
    }
}