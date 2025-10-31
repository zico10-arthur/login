using login.Domain.Entities;
using login.Application.Validacoes;
using login.Infraestructure.Repository;

namespace login.Application.ContaService
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

        public static void AlterarSenha(Conta conta, string NovaSenha)
        {
            Validacoesservice.ValidacoesSenha(new Conta { Senha = NovaSenha});
            ContaRepository.AlterarSenha(conta, NovaSenha);
        }

        public static bool Autenticar(Conta conta)
        {
            return ContaRepository.Autenticacao(conta);
        }

        public static List<Conta> ListarConta()
        {
            return ContaRepository.ListarConta();
        }
    }
}
