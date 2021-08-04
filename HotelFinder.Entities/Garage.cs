using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Entities
{

    public class Garage  
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GarageId { get; set; }

        public int HotelId { get; set; }
        [ForeignKey("HotelId")]
        public virtual Hotel Hotel { get; set; }

        public int Capacity { get; set; }

        public int CarCount { get; set; }
    }
}
