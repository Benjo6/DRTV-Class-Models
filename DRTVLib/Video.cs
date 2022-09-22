using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRTVLib
{
    public sealed class Video
    {
        public String Id_Video { get; set; }
        public TimeOnly Duration { get; set; }
        public byte[] Visualization { get; set; }

        [ForeignKey("id_content")]
        public String ContentId { get; set; }
        [ForeignKey("id_episode")]
        public int EpisodeId { get; set; }

        public void SetCurrentVideo()
        {

        }
    }
}
