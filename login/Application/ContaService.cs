using login.Domain.Entities;
using login.Application.Validacoes;
using login.Infraestructure.Repository;
using login.Domain.Interfaces;
using login.Application.Dtos;

namespace login.Application.ContaService
{
    public class ContaService
    {
        private readonly IContaRepository _repository;

        public ContaService(IContaRepository repository)
        {
            _repository = repository;
        }
        public void AdicionarConta(CriarContaDTO dto)
        {
            Conta conta = dto.Mapper();
            Validacoesservice.ValidacoesNomeSobreNome(conta);
            Validacoesservice.ValidacoesEmail(conta);
            Validacoesservice.ValidacoesSenha(conta);

            _repository.AdicionarConta(conta);
        }

        public void AlterarSenha(AlterarSenhaDto dto)
        {
            Conta conta = dto.Mapear();
            Validacoesservice.ValidacoesSenha(conta);
            _repository.AlterarSenha(conta);
        }

        public void Autenticar(AutenticarDTO dto)
        {
            Conta conta = dto.Mapper();
            Validacoesservice.ValidarLogin(conta);
            _repository.Autenticacao(conta);
        }

        public List<Conta> ListarConta()
        {
            return _repository.ListarConta();
        }
    }
}
