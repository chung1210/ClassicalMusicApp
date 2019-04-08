using App.Model.Abstract;
using App.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Model.Model
{
    [Table("BaiHats")]
    public class BaiHat : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaBaiHat { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenBaiHat { set; get; }

        public int LuotNghe { get; set; }
        public TinhTrangBaiHat TinhTrangBaiHat { get; set; }

        //[Column(TypeName ="varchar(250)")]
        [MaxLength(250)]
        public string MoreImage { get; set; }

        [MaxLength(250)]
        public string Url { get; set; }

        [Required]
        public int MaCaSi { get; set; }

        [Required]
        public int MaAlbum { get; set; }
        [ForeignKey("MaCaSi")]
        public virtual CaSi CaSi { get; set; }
        [ForeignKey("MaAlbum")]
        public virtual Album Album { get; set; }


    }
}
