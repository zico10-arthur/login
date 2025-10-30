using System.Net.Mail;
using login.Domain.Entities;
using login.Domain.Entities.ContaExceptions;


namespace login.Application
{
    public  static class Validacoesservice
    {
        public static void ValidacoesNomeSobreNome(Conta conta)
        {
            if (string.IsNullOrWhiteSpace(conta.Nome) || string.IsNullOrWhiteSpace(conta.SobreNome))
            {
                throw new NomeSobrenomeInvalidaExceptions();
            }
            if (!conta.Nome.All(c => char.IsLetter(c) || c == ' ') ||
                !conta.SobreNome.All(c => char.IsLetter(c) || c == ' '))
            {
                throw new NomeSobreNomestringExceptions();
            }
        }
        public static void ValidacoesEmail(Conta conta)
        {
            if (string.IsNullOrWhiteSpace(conta.Email))
            {
                throw new EmailEmBrancoException();
            }
            try
            {
                MailAddress mail = new MailAddress(conta.Email);
            }
            catch (FormatException)
            {
                throw new EmailInvalidoException();
            }
        }

        public static void ValidacoesSenha(Conta conta)
        {
            if (conta.Senha.Length < 8 ||
                !conta.Senha.Any(char.IsLetter) ||
                !conta.Senha.Any(char.IsDigit) ||
                !conta.Senha.Any(c => !char.IsLetterOrDigit(c))
                ) 
            {
                throw new SenhaInvalidaException();
            }
        }
    }
}
