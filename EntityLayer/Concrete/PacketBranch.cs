using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PacketBranch
    {
        public int PacketId { get; set; }
        public int BranchId { get; set; }
        public Packet? Packet { get; set; }
        public Branch? Branch { get; set; }

    }
}
