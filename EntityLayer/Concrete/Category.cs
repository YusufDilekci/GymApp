using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryInfo { get; set; }
        public double CategoryPrice { get; set; }
        public List<string> CategoryDescriptions { get; set; } = new List<string>();
        public List<string> CategoryImages { get; set; } = new List<string>();
        public List<MemberCategory> Members { get; } = new();
        public virtual ICollection<Trainer>? Trainers { get; set; }
    }
}
