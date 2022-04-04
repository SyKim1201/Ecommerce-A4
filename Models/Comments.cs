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

        public string Text { get; set; }

        public int UserID { get; set; }

        public int ProductID { get; set; }

        public int Rating { get; set; }

        public DateTime CommentedAt { get; set; }
    }
}