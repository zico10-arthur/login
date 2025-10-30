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
 
            
        }
        public static void AlterarSenha(Conta conta, string NovaSenha)
        {
            Conta? ContaCadastrada = DataBase.contas.Find(c => c.Email == conta.Email);
            
            if (ContaCadastrada != null)
            {
                ContaCadastrada.Senha = NovaSenha;
            }

        }

        public static bool Autenticacao(Conta conta)
        {
            Conta? ContaCadastrada = DataBase.contas.Find(c => c.Email == conta.Email && c.Senha == conta.Senha);

            if (ContaCadastrada != null)
            {
                return true;
            }
            return false;
            

        }


    }

       


}
