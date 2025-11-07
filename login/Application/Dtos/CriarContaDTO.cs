using login.Domain.Entities;

namespace login.Application.Dtos
{
    public class CriarContaDTO
    {
        public string Nome { get; set; } = string.Empty;

        public string SobreNome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Senha { get; set; } = string.Empty;

        public Conta Mapper()
        {
            return new Conta
            {
                Nome = Nome,
                SobreNome = SobreNome,
                Email = Email,
                Senha = Senha
            };
        }

    }
}
