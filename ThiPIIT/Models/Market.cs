using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models
{
    public class Market
    {
        public int id { get; set; }

        [DisplayName("name")]
        [Required(ErrorMessage = "Please enter name")]
        public string name { get; set; }

        [DisplayName("description")]
        [Required(ErrorMessage = "Please enter description")]
        public string description { get; set; }

        [DisplayName("createdAt")]
        [Required(ErrorMessage = "Please enter createdAt")]
        public DateTime createdAt { get; set; }

        [DisplayName("updatedAd")]
        [Required(ErrorMessage = "Please enter updatedAd")]
        public DateTime updatedAd { get; set; }

        [DisplayName("status")]
        [Required(ErrorMessage = "Please enter status")]
        public int status { get; set; }
        public virtual ICollection<Coin> Coins { get; set; }
    }
}