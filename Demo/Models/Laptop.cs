using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Demo.Models
{
    //Many Laptop - 1 Brand
    public class Laptop
    {
        public int Id { get; set; } //primary key
        //[Required (ErrorMessage = "Tên laptop không được để trống")]
        [MinLength(3, ErrorMessage = "Tên laptop phải tối thiểu 3 ký tự")]
        [MaxLength(50, ErrorMessage = "Tên laptop phải có tối đa 50 ký tự")]
        public string Model { get; set; }
        public string Color { get; set; }
        [Required (ErrorMessage = "Số lượng không được để trống")]
        [Range(1, 50, ErrorMessage = "Số lượng phải từ 1 đến 50")]
        public int Quantity { get; set; }
        [Required (ErrorMessage = "Giá tiền không được để trống")]
        public double Price { get; set; }
        [Url(ErrorMessage = "Link ảnh không hợp lệ")]
        public string Image { get; set; }

        public int BrandId { get; set; }  //foreign key
        public Brand Brand { get; set; }
    }
}