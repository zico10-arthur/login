using login.Domain.Entities;
using login.Domain.Entities.ContaExceptions;
using login.Domain.Interfaces;
using login.Infraestructure.Data;

namespace login.Domain.Interfaces
{
    public interface IContaRepository 
    {
        void AdicionarConta(Conta conta);
        void AlterarSenha(Conta conta, string NovaSenha);
        Conta Autenticacao(Conta conta);
        List<Conta> ListarConta();
    }
}
