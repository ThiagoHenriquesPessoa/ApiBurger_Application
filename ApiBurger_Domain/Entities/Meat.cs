using System.ComponentModel.DataAnnotations;

namespace ApiBurger_Domain.Entities
{
    public class Meat
    {
        [Key]
        public int Id_Meat { get; set; }
        public string Name { get; set; }
    }
}