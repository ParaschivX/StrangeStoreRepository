using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class FinalModel
    {
        public ApplicationUser User { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
