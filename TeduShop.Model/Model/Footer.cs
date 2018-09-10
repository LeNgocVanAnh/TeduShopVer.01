using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key] // xác định khóa chính
        [MaxLength(50)] //để gener ra kiểu dữ liệu có độ dài mặc định để tránh tốn bộ nhớ
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}