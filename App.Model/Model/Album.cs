using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Model
{
    [Table("Albums")]
    public class Album
    {
        public Album()
        {
            BaiHats = new List<BaiHat>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaAlbum { get; set; }
        [StringLength(50)]
        public string TenAlbum { get; set; }

        public virtual ICollection<BaiHat> BaiHats { get; set; }
    }
}
