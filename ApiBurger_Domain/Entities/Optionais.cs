using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBurger_Domain.Entities
{
    public class Optionais
    {
        [Key]
        public int Id_Optionais { get; set; }
        [ForeignKey("Id_Burger")]
        public int Id_Burger { get; set; }
        [ForeignKey("Id_Optional")]
        public int Id_Optional { get; set; }
    }
}