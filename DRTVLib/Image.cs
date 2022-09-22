using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRTVLib
{
    public sealed class Image
    {
        public String Id_Image { get; set; }
        public byte[] ImageCover { get; set; }
        public String Description { get; set; }
        [ForeignKey("id_content")]
        public String ContentId { get; set; }

        public void GetPostImage()
        {

        }
    }
}
