namespace ApiBurger_Domain.Entities
{
    public class Entity
    {
        public int Id;

        public Entity()
        {
            Random id = new Random();
            Id = id.Next(10, 50);
        }
    }
}