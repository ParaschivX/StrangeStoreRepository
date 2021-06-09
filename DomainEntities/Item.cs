using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
       [Required]
        [Range(1,100,ErrorMessage ="Rating must be between 1 and 100")]
        public int Rating { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public int ItemTypeId { get; set; }
        [ForeignKey("ItemTypeId")]
        public virtual ItemType ItemType{ get; set; }

    }
}
