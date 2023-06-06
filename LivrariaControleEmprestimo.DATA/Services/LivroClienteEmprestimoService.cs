using LivrariaControleEmprestimo.DATA.Repositories;

namespace LivrariaControleEmprestimo.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryLivroClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }
        public RepositoryCliente oRepositoryCliente { get; set; }

        public LivroClienteEmprestimoService()
        {
            oRepositoryLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryCliente = new RepositoryCliente();   
        }
    }
}
