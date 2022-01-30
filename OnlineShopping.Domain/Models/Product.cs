using System.ComponentModel.DataAnnotations;
using OnlineShopping.Core.Entity;

namespace OnlineShopping.OrderContext
{
    public class Product : Entity
    {
        [Required]
        public virtual string Name { get; set; } 
    }
}