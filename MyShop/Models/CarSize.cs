using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Models
{
    public class CarSize
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarSizeID { get; set; }

        [MinLength(1)]
        [MaxLength(50)]
        public string CarSizeName { get; set; }
    }
}
