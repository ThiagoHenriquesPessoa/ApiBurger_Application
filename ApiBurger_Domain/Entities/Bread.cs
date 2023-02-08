using System.ComponentModel.DataAnnotations;

namespace ApiBurger_Domain.Entities
{
    public class Bread
    {
        [Key]
        public int Id_Bread { get; set; }
        public string Name { get; set; }
    }
}