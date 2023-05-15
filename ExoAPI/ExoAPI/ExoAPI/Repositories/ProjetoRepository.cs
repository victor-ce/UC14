using ExoAPI.Contexts;
using ExoAPI.Models;

namespace ExoAPI.Repositories
{
    public class ProjetoRepository
    {

        private readonly ExoContext _context;

        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }
        //Retorna a lista de projetos
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId( int Id)
        {
            return _context.Projetos.Find(Id);
        }

        public void Cadastrar( Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar (int Id, Projeto projeto)
        {
            Projeto projetoBuscado = _context.Projetos.Find(Id);
            if (projetoBuscado != null)
            {
                projetoBuscado.NomeProjeto = projeto.NomeProjeto;

                projetoBuscado.DataInicio = projeto.DataInicio;

                projetoBuscado.DataTermino = projeto.DataTermino;

                projeto.Tecnologias = projeto.Tecnologias;
            }

            _context.Projetos.Update(projetoBuscado);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            //cria um objeto livro, e busca o livro com o id fornecido;
            Projeto projeto = _context.Projetos.Find(id);

            //remove o livro buscado;
            _context.Projetos.Remove(projeto);

            //salva as mudanças realizadas no bando de dados;
            _context.SaveChanges();
        }

    }
}
