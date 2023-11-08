using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Image : IEntity
    {
        [Key]
        public int ImageId { get; set; }
        public int BranchId { get; set; }
        public string ImageName { get; set; }
        public Branch Branch { get; set; }
    }
}
