using login.Domain.Entities;

namespace login.Application.Dtos
{
    public class AutenticarDTO
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        public Conta Mapper()
        {
            return new Conta
            {
                Email = Email,
                Senha = Senha
            };
        }
    }
}
