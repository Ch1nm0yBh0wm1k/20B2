using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
