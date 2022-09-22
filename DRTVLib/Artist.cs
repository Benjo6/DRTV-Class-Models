using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRTVLib
{
    public sealed class Artist
    {
        public String FullName { get; set; }
        public Role Role { get; set; }
        public List<Content> Appearances { get; set; }
    }
}
