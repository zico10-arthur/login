using login.Domain.Entities;
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
                throw new 
            }
            
        }

        public static void RemoverConta(Conta conta)
        {
            Conta? ContaCadastrada = DataBase.contas.Find(c => c.Email == conta.Email);

            if (ContaCadastrada != null)
            {
                DataBase.contas.Remove(conta);

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

        public static List<Conta> ListarContas()
        {
            return DataBase.contas.ToList();
        }
    }

       


}
