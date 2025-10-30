using login.Domain.Entities;
using login.Application.Validacoes;
using login.Infraestructure.Repository;

namespace login.Application
{
    public static class ContaService
    {
        public static void AdicionarConta(Conta conta)
        {
            Validacoesservice.ValidacoesNomeSobreNome(conta);
            Validacoesservice.ValidacoesEmail(conta);
            Validacoesservice.ValidacoesSenha(conta);

            ContaRepository.AdicionarConta(conta);
        }
    }
}
