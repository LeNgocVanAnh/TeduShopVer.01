using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("FeedBacks")]
    public class FeedBack
    {
        [Key]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Email { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [MaxLength(250)]
        public string Message { set; get; }

      
        public DateTime CreatedDate { set; get; }


        public bool Status { set; get; }
    }
}
