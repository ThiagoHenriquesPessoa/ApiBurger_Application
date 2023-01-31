using ApiBurger_Domain.Enum;

namespace ApiBurger_Domain.Entities
{
    public class Status
    {
        public int Id { get; set; }
        public StatusRequest Tipo { get; set; }
    }
}