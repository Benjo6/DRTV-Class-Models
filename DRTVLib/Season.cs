using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRTVLib
{
    public sealed class Season
    {
        public int Number_Season { get; set; }
        public String Description { get; set; }
        public List<Episode> Episodes { get; set; }
        public List<Content> Contents { get; set; }

        public void SetCurrentSeason()
        {

        }
        public void FetchEpisodesForEachSeason()
        {

        }
    }
}
