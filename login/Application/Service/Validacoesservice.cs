using System.Net.Mail;
using login.Domain.Entities;
using login.Domain.ContaExceptions;
using System.Xml.Schema;
using login.Application.Dtos;


namespace login.Application.Service
{
    public class Validacoesservice
    {
        
        public static void ValidacoesNomeSobreNome(CriarContaDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Nome) || string.IsNullOrWhiteSpace(dto.SobreNome))
            {
                throw new NomeSobrenomeInvalidaExceptions();
            }
            if (!dto.Nome.All(c => char.IsLetter(c) || c == ' ') ||
                !dto.SobreNome.All(c => char.IsLetter(c) || c == ' '))
            {
                throw new NomeSobreNomestringExceptions();
            }
        }
        public static void ValidacoesEmail(CriarContaDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Email))
            {
                throw new EmailEmBrancoException();
            }
            try
            {
                MailAddress mail = new MailAddress(dto.Email);
            }
            catch (FormatException)
            {
                throw new EmailInvalidoException();
            }
        }

        public static void ValidacoesSenha(CriarContaDTO dto)
        {
            if (dto.Senha.Length < 8 ||
                !dto.Senha.Any(char.IsLetter) ||
                !dto.Senha.Any(char.IsDigit) ||
                !dto.Senha.Any(c => !char.IsLetterOrDigit(c))
                ) 
            {
                throw new SenhaInvalidaException();
            }
        }
        public static void ValidarLogin(AutenticarDTO dto)
        {
            
            if (dto.Senha.Trim() == "" || dto.Email.Trim() == "")
            {
                throw new ValidarLoginException();
            }

        }

        public static void ValidacoesNovaSenha(AlterarSenhaDto dto)
        {
            if (dto.NovaSenha.Length < 8 ||
                !dto.NovaSenha.Any(char.IsLetter) ||
                !dto.NovaSenha.Any(char.IsDigit) ||
                !dto.NovaSenha.Any(c => !char.IsLetterOrDigit(c))
                )
            {
                throw new SenhaInvalidaException();
            }
        }


    }
}
