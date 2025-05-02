using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryAPI.Models
{
    public class Transaction
    {
        public int id { get; set; }

        [Required]
        public int productid { get; set; } 

        [Required]
        public int quantity { get; set; }  

        [Required]
        public string type { get; set; }  

        [Required]

        public DateTime date { get; set; } = DateTime.UtcNow;

        public Product? Product { get; set; } 
    }

}