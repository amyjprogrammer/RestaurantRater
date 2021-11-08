using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }

        [DisplayName("Restaurant Name")]
        public string Name { get; set; }

        [DisplayName("Location")]
        public string Address { get; set; }

        [Range(1, 10)]
        public int Rating { get; set; }
    }
}