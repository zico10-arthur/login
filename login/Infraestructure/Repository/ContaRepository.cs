using login.Domain.Entities;
using login.Domain.Entities.ContaExceptions;
using login.Infraestructure.Data;
using login.Domain.Interfaces;
namespace login.Infraestructure.Repository
{
    public class ContaRepository : IContaRepository
    {
        private readonly DataBase _db;

        public ContaRepository(DataBase db)
        {
            _db = db;
        }
        public void AdicionarConta(Conta conta)
        {
            Conta? ContaCadastrada = _db.contas.Find(c => c.Email == conta.Email);

            if (ContaCadastrada == null)
            {
                _db.contas.Add(conta);
            }
            else
            {
                throw new ContaExisteExceptions(); 
            }
 
            
        }
        public void AlterarSenha(Conta conta)
        {
            Conta? ContaCadastrada = _db.contas.Find(c => c.Email == conta.Email);
            
            if (ContaCadastrada != null)
            {
                ContaCadastrada.Senha = conta.Senha;
            }
            else
            {
                throw new LoginExistenteException();
            }

        }

        public Conta Autenticacao(Conta conta)
        {
            Conta? ContaCadastrada = _db.contas.Find(c => c.Email == conta.Email && c.Senha == conta.Senha);

            if (ContaCadastrada != null)
            {
                return ContaCadastrada;
            }
            else
            {
                throw new LoginExistenteException();
              
            }
            

        }
        public List<Conta> ListarConta()
        {
            return _db.contas.ToList();
        }


    }

       


}
