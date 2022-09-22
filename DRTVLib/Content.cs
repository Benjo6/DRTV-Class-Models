using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRTVLib
{
    public sealed class Content
    {
        public String ContentId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime Publish_Date { get; set; }
        public Language Language { get; set; }
        public Genre Genre { get; set; }
        public double Rating { get; set; }
        [ForeignKey("id_video")]
        public String VideoId { get; set; }
        [ForeignKey("id_image")]
        public String ImageId { get; set; }
        [ForeignKey("id_season")]
        public String SeasonId { get; set; }

        public List<Artist> Artists { get; set; }
        

        public void FetchInfo()
        {

        }

    }
}
