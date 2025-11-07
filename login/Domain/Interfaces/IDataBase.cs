using login.Domain.Entities;

namespace login.Domain.Interfaces
{
    public interface IDataBase
    {
        void AdicionarConta(Conta conta);
        List<Conta> ListarConta();
        void AlterarSenha(string email, string NovaSenha);
        Conta? Autenticar(string Email);
    }
}
