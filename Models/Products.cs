using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce4.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //Product title
        public string Title { get; set; }
        //Product Description
        public string Description { get; set; }
        //Quantity
        public int Quantity { get; set; }
        //Price
        public int Price { get; set; }
        //Image of the product
        public string BannerImage { get; set; }
        //Thumbnail o the product
        public string ThumbnailImage { get; set; }
        //shipping cost 
        public int ShippingCost { get; set; }

    }
}
