using login.Domain.Entities;
using login.Domain.Entities.ContaExceptions;
using login.Infraestructure.Data;

namespace login.Infraestructure.Repository
{
    public class ContaRepository
    {
        public static void AdicionarConta(Conta conta)
        {
            Conta? ContaCadastrada = DataBase.contas.Find(c => c.Email == conta.Email);

            if (ContaCadastrada == null)
            {
                DataBase.contas.Add(conta);
            }
            else
            {
                throw new ContaExisteExceptions(); 
            }
 
            
        }
        public static void AlterarSenha(Conta conta, string NovaSenha)
        {
            Conta? ContaCadastrada = DataBase.contas.Find(c => c.Email == conta.Email);
            
            if (ContaCadastrada != null)
            {
                ContaCadastrada.Senha = NovaSenha;
            }
            else
            {
                throw new LoginExistenteException();
            }

        }

        public static Conta Autenticacao(Conta conta)
        {
            Conta? ContaCadastrada = DataBase.contas.Find(c => c.Email == conta.Email && c.Senha == conta.Senha);

            if (ContaCadastrada != null)
            {
                return ContaCadastrada;
            }
            else
            {
                throw new LoginExistenteException();
              
            }
            

        }
        public static List<Conta> ListarConta()
        {
            return DataBase.contas.ToList();
        }


    }

       


}
