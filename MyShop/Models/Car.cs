using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarID { get; set; }

        [MinLength(1)]
        [MaxLength(50)]
        public string CarName { get; set; }

        

        //servisesID here forign key
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        //carsizeID here forign key
        public int CarSizeID { get; set; }
        public CarSize CarSize { get; set; }




    }
}
