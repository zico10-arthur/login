using login.Domain.Entities;

namespace login.Infraestructure.Data
{
    public class DataBase
    {
        public List<Conta> contas { get; set; } = new();
    }
}
