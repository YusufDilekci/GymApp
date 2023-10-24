﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; }
        public int CategoryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TrainerDescription { get; set; }
        public string TrainerImage { get; set; }
        public Category Category { get; set; }
        public List<MemberTrainer> Members { get; set; }
    }
}
