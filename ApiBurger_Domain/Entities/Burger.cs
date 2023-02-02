namespace ApiBurger_Domain.Entities
{
    public class Burger
    {
        public int Id { get; set; }
        public Meat Meat { get; set; }
        public Bread Bread { get; set; }
        public Optional Optional { get; set; }
        public int Status { get; set; }
    }
}