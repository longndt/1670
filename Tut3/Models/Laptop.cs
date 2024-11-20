using System.Net.NetworkInformation;

namespace Tut3.Models
{
    //Many Laptop - 1 Brand
    public class Laptop
    {
        public int Id { get; set; } //primary key
        public string Model { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public int BrandId { get; set; }  //foreign key
        public Brand Brand { get; set; }
    }
}