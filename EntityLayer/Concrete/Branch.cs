using CoreLayer.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Branch : IEntity
    {
        [Key]
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string BranchInfo { get; set; }
        public double BranchPrice { get; set; }
        public List<MemberBranch>? Members { get; set; }
        public List<PacketBranch>? Packets { get; set; }
        public  ICollection<Description>? Descriptions { get; set; }
        public  ICollection<Image>? Images { get; set; }
        public  ICollection<Trainer>? Trainers { get; set; }
    }
}
