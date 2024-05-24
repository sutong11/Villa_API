using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaAPI.Models
{
    public class Villa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  //it will automatically manage the id for us
        public int Id { get; set; }  // this to be identity column

        [Required]
        public string Name { get; set; }

        public string Details { get; set; }

        public double Rate { get; set; }

        public int Sqft { get; set; }

        public int Occupancy { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }


        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
