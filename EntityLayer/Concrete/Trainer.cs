using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Trainer : IEntity
    {
        [Key]
        public int TrainerId { get; set; }
        public int BranchId { get; set; }
        public string NameSurname { get; set; }
        public string TrainerDescription { get; set; }
        public string TrainerImage { get; set; }
        public Branch? Branch { get; set; }
        public List<MemberTrainer>? Members { get; set; }
    }
}
