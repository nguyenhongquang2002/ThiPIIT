using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThiPIIT.Models
{
    public class Coin
    {
        public int id { get; set; }

        [DisplayName("name")]
        [Required(ErrorMessage = "Please enter name")]
        public string name { get; set; }

        [DisplayName("baseAsset")]
        [Required(ErrorMessage = "Please enter baseAsset")]
        public string baseAsset { get; set; }

        [DisplayName("MyProperty")]
        [Required(ErrorMessage = "Please enter MyProperty")]
        public string MyProperty { get; set; }

        [DisplayName("quoteAsset")]
        [Required(ErrorMessage = "Please enter quoteAsset")]
        public string quoteAsset { get; set; }

        [DisplayName("lastPrice")]
        [Required(ErrorMessage = "Please enter lastPrice")]
        public int lastPrice { get; set; }

        [DisplayName("volumn24h")]
        [Required(ErrorMessage = "Please enter volumn24h")]
        public string volumn24h { get; set; }

        [DisplayName("marketId")]
        [Required(ErrorMessage = "Please enter marketId")]
        public int MarketId { get; set; }

        [DisplayName("createdAt")]
        [Required(ErrorMessage = "Please enter createdAt")]
        public DateTime createdAt { get; set; }

        [DisplayName("updatedAd")]
        [Required(ErrorMessage = "Please enter updatedAd")]
        public DateTime updatedAd { get; set; }

        [DisplayName("status")]
        [Required(ErrorMessage = "Please enter status")]
        public int status { get; set; }

        public virtual Market Market { get; set; }
    }
}