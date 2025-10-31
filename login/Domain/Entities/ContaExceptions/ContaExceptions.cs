using System.Buffers.Text;

namespace login.Domain.Entities.ContaExceptions
{
    public class ContaExisteExceptions : Exception
    {
       public ContaExisteExceptions()
            : base ("já existe um usuário com este login.") { }

    }

    public class SenhaInvalidaException : Exception
    {
        public SenhaInvalidaException()
            : base("Escolha uma senha mais segura. Use uma combinação de letras, números e símbolos.") { }
    }

    public class NomeSobrenomeInvalidaExceptions : Exception
    {
        public NomeSobrenomeInvalidaExceptions()
           : base("Nome e Sobrenome são obrigatórios") { }

    }
    public class NomeSobreNomestringExceptions : Exception 
    { 
        public NomeSobreNomestringExceptions()
            : base(" tem certeza que esse é o seu nome? ") { }
    
    }
    public class EmailInvalidoException : Exception
    {
        public EmailInvalidoException()
            : base("digite um email válido") { }
    }
    public class EmailEmBrancoException : Exception
    {
        public EmailEmBrancoException()
            : base("o email não pode ser vazio") { }
    }
    public class LoginExistenteException : Exception
    {
        public LoginExistenteException()
            : base("esse login não existe") { }
    }
   


}
