﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityLayer.Concrete
{
    public class MemberBranch
    {
        public int MemberId { get; set; }
        public int BranchId { get; set; }
        public Member Member { get; set; }
        public Branch Branch { get; set; }
    }
}
