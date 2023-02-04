using ApiBurger_Domain.Enum;

namespace ApiBurger_Domain.Entities
{
    public class Burger
    {
        public int Id_Burger { get; set; }
        public string Name { get; set; }
        public int Id_Meat { get; set; }
        public int Id_Bread { get; set; }
        public Status Status { get; set; }
        public List<Optional>? Optional { get; set; }        
    }
}