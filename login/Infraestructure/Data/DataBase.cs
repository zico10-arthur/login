using login.Domain.ContaExceptions;
using login.Domain.Entities;
using login.Domain.Interfaces;
namespace login.Infraestructure.Data
{
    public class DataBase : IDataBase
    {
        private readonly List<Conta> contas = new();

        public List<Conta> ListarConta()
        {
            return contas.ToList();
        }
        public void AdicionarConta(Conta conta)
        {
            contas.Add(conta);
        }
        public void AlterarSenha(string email, string NovaSenha)
        {
            Conta conta = Autenticar(email);

            if (conta != null)
            {
                conta.Senha = NovaSenha;
            }
        }
        public Conta? Autenticar(string email)
        {
            return contas.FirstOrDefault(c => c.Email == email);
        }


    }
}
