using ChapterFST1.Contexts;
using ChapterFST1.Models;

namespace ChapterFST1.Repositories
{
    public class LivroRepository
    {
        // possui acesso aos dados
        private readonly ChapterContext _context;
        // somente um data context na memória da aplicação na requisição, evitar o usar o new
        // para o repositório existir, precisa do contexto, a aplicacao cria
        // configurar no startup
        public LivroRepository(ChapterContext context)
        {
            _context = context;
        }
        // retorna a lista de livros
        public List<Livro> Listar()
        {
            // SELECT Id, Titulo, QuantidadePaginas, Disponivel FROM Livros;
            return _context.Livros.ToList();
        }

        public Livro BuscarPorId( int id)
        {
            //busca e retorna o livro com o id fornecido;
            return _context.Livros.Find(id);
        }

        public void Cadastrar( Livro livro)
        {
            _context.Livros.Add(livro);

            _context.SaveChanges();
        }

        public void Atualizar(int id, Livro livro)
        {
            //cria um objeto livro, e busca o livro com o id fornecido;
            Livro livroBuscado = _context.Livros.Find(id);

            // se o livro for encontrado, seus valores são atualizados;
            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;

                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;

                livroBuscado.Disponivel = livro.Disponivel;
            }
            
            //atualiza os dados no bando de dados;
            _context.Livros.Update(livroBuscado);

            // salva as mudanças realizadas no banco de dados;
            _context.SaveChanges();
        }


        public void Deletar(int id)
        {
            //cria um objeto livro, e busca o livro com o id fornecido;
            Livro livro = _context.Livros.Find(id);

            //remove o livro buscado;
            _context.Livros.Remove(livro);

            //salva as mudanças realizadas no bando de dados;
            _context.SaveChanges();
        }




    }

}
