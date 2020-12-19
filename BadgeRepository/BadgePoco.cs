using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepository
{
    public class BadgePoco
    {
        public List<string> DoorNames { get; set; } = new List<string>();
        public int BadgeID { get; set; }
        public BadgePoco() { }
        public BadgePoco(int badgeId, List<string> doorNames)
        {
            BadgeID = badgeId;
            DoorNames = doorNames;
        }
    }
}
