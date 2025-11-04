using login.Domain.Entities;
using login.Application.Validacoes;
using login.Infraestructure.Repository;
using login.Domain.Interfaces;

namespace login.Application.ContaService
{
    public class ContaService
    {
        private readonly IContaRepository _repository;

        public ContaService(IContaRepository repository)
        {
            _repository = repository;
        }
        public void AdicionarConta(Conta conta)
        {
            Validacoesservice.ValidacoesNomeSobreNome(conta);
            Validacoesservice.ValidacoesEmail(conta);
            Validacoesservice.ValidacoesSenha(conta);

            _repository.AdicionarConta(conta);
        }

        public void AlterarSenha(Conta conta, string NovaSenha)
        {
            Validacoesservice.ValidacoesSenha(new Conta { Senha = NovaSenha});
            _repository.AlterarSenha(conta, NovaSenha);
        }

        public void Autenticar(Conta conta)
        {
            Validacoesservice.ValidarLogin(conta);
            _repository.Autenticacao(conta);
        }

        public List<Conta> ListarConta()
        {
            return _repository.ListarConta();
        }
    }
}
