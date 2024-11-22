using System.Collections.Generic;

namespace Tut3.Models
{
    //1 Brand - Many Laptop
    public class Brand
    {
        public int Id { get; set; }  //primary key
        public string Name { get; set; }

        public ICollection<Laptop> Laptops { get; set; }
    }
}
