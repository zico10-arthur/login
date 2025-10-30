using login.Domain.Entities;

namespace login.Infraestructure.Data
{
    public class DataBase
    {
        public static List<Conta> contas { get; set; } = new();
    }
}
