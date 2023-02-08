using System.ComponentModel.DataAnnotations;

namespace ApiBurger_Domain.Entities
{
    public class Optional
    {
        [Key]
        public int Id_Optional { get; set; }
        public string Name { get; set; }
    }
}