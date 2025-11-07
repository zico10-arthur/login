using login.Application.Dtos;
using login.Domain.Entities;

namespace login.Application.Interface
{
    public interface IContaService
    {
        void AdicionarConta(CriarContaDTO dto);
        void AlterarSenha(AlterarSenhaDto dto);
        Conta Autenticar(AutenticarDTO dto);
        List<Conta> ListarConta();
    }
}
