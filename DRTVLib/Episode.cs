using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRTVLib
{
    public sealed class Episode
    {
        public int EpisodeId { get; set; }
        public String Episode_Number { get; set; }
        public String Description { get; set; }

        [ForeignKey("number_season")]
        public int Number_Season { get; set; }

        public void SetCurrentEpisode()
        {

        }
    }
}
