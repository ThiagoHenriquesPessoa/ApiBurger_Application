using ApiBurger_Domain.Enum;

namespace ApiBurger_Domain.Entities
{
    public class Status : Entity
    {
        public StatusRequest Tipo { get; set; }
    }
}