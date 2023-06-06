using LivrariaControleEmprestimo.DATA.Models;

namespace LivrariaControleEmprestimo.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro? oLivro { get; set; }
        public Cliente? oCliente { get; set; }
        public DateTime? dataEmprestimo { get; set; }
        public DateTime? dataEntrega { get; set; }
        public int idCliente { get; set; }
        public int idLivro { get; set; }
        public List<Cliente> oListCliente { get; set; } 
        public List<Livro> oListLivro { get; set; }    
    }
}
