using login.Domain.Entities;
using login.Domain.ContaExceptions;
using login.Infraestructure.Data;
using login.Domain.Interfaces;
using System.Diagnostics.Eventing.Reader;
namespace login.Infraestructure.Repository
{
    public class ContaRepository : IContaRepository
    {
        private readonly IDataBase _db;

        public ContaRepository(IDataBase db)
        {
            _db = db;
        }
        public void AdicionarConta(Conta conta)
        {
            Conta? ContaCadastrada = _db.Autenticar(conta.Email);

            if (ContaCadastrada == null)
            {
                _db.AdicionarConta(conta);
            }
            else
            {
                throw new ContaExisteExceptions(); 
            }
 
            
        }
        public void AlterarSenha(Conta conta)
        {
            Conta? ContaCadastrada = _db.Autenticar(conta.Email);
            
            if (ContaCadastrada != null)
            {
                _db.AlterarSenha(conta.Email, conta.Senha);
            }
            else
            {
                throw new LoginExistenteException();
            }

        }

        public Conta Autenticacao(Conta conta)
        {
            Conta? ContaCadastrada = _db.Autenticar(conta.Email);

            if (ContaCadastrada != null && ContaCadastrada.Senha == conta.Senha)
            {
                return ContaCadastrada;
            }
            
            {
                throw new LoginExistenteException();

            }
    
        }
        public List<Conta> ListarConta()
        {
            return _db.ListarConta();
        }


    }

       


}
