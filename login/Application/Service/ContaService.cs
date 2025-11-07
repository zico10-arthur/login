using login.Domain.Entities;
using login.Domain.Interfaces;
using login.Application.Dtos;
using login.Application.Interface;

namespace login.Application.Service
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _repository;

        public ContaService(IContaRepository repository)
        {
            _repository = repository;
        }
        public void AdicionarConta(CriarContaDTO dto)
        {
            Conta conta = dto.Mapper();
            Validacoesservice.ValidacoesNomeSobreNome(dto);
            Validacoesservice.ValidacoesEmail(dto);
            Validacoesservice.ValidacoesSenha(dto);

            _repository.AdicionarConta(conta);
        }

        public void AlterarSenha(AlterarSenhaDto dto)
        {
            Conta conta = dto.Mapear();
            Validacoesservice.ValidacoesNovaSenha(dto);
            _repository.AlterarSenha(conta);
        }

        public Conta Autenticar(AutenticarDTO dto)
        {
            Conta conta = dto.Mapper();
            Validacoesservice.ValidarLogin(dto);
             return _repository.Autenticacao(conta);
        }

        public List<Conta> ListarConta()
        {
            return _repository.ListarConta();
        }
    }
}
