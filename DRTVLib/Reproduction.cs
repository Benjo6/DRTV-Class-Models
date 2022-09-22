using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRTVLib
{
    public sealed class Reproduction
    {
        public String Id_Reproduction { get; set; }
        public double Position { get; set; }
        public DateTime Reproduction_Date { get; set; }

        [ForeignKey("userId_Profile")]
        public String UserId_Profile { get; set; }
        public User User { get; set; }
        public List<Video> Videos { get; set; }

        public void FetchCurrentTime()
        {

        }
        public void FetchActiveVideos()
        {

        }
    }
}
