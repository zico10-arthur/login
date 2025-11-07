using login.Domain.Entities;

namespace login.Application.Dtos
{
    public class AlterarSenhaDto
    {
        public string Email { get; set; } = string.Empty;
        public string NovaSenha { get; set; } = string.Empty;

        public Conta Mapear()
        {
            return new Conta()
            {
                Email = Email,
                Senha = NovaSenha
            };
        }
    }

}


