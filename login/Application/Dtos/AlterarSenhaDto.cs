using login.Domain.Entities;

namespace login.Application.Dtos
{
    public class AlterarSenhaDto
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        public Conta Mapear()
        {
            return new Conta()
            {
                Email = this.Email,
                Senha = this.Senha
            };
        }
    }

}


