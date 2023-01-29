namespace ApiBurger_Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }

        public Entity()
        {
            Random id = new Random();
            Id = id.Next();
        }
    }
}