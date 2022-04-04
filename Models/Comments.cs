using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce4.Models
{
    public class Comments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //text of the comments
        public string Text { get; set; }
        //User id of the commentor
        public int UserID { get; set; }
        //product id on which comment is made
        public int ProductID { get; set; }
        //Rating of the product
        public int Rating { get; set; }

        public DateTime CommentedAt { get; set; }
    }
}