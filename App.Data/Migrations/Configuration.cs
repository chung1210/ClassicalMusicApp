using App.Model.Enums;
using App.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(AppDbContext context)
        {
            CreateCaSi(context);
            CreateAlbum(context);
            CreateBaiHat(context);
        }

        private void CreateCaSi(AppDbContext context)
        {
            if (context.CaSies.Count() == 0)
            {
                List<CaSi> listProductCategory = new List<CaSi>()
            {
                new CaSi(){MaCaSi=1,TenCaSi="Ca Si 1" },
                new CaSi(){MaCaSi=2,TenCaSi="Ca Si 2"  },
                new CaSi(){MaCaSi=3,TenCaSi="Ca Si 3"  },
                new CaSi(){MaCaSi=4,TenCaSi="Ca Si 4"  }
            };
                context.CaSies.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
        private void CreateAlbum(AppDbContext context)
        {
            if (context.Albums.Count() == 0)
            {
                List<Album> listProductCategory = new List<Album>()
            {
                new Album(){MaAlbum=1,TenAlbum="Album 1 " },
                new Album(){MaAlbum=2,TenAlbum="Album 2" },
                new Album(){MaAlbum=3,TenAlbum="Album 3" },
                new Album(){MaAlbum=4,TenAlbum="Album 4" }
            };
                context.Albums.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
        private void CreateBaiHat(AppDbContext context)
        {//https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg
            if (context.BaiHats.Count() == 0)
            {
                List<BaiHat> listProductCategory = new List<BaiHat>()
            {
                new BaiHat(){TenBaiHat="BAI HAT 1",LuotNghe=1,TinhTrangBaiHat=TinhTrangBaiHat.Active,MoreImage="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg" ,Url="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg",MaCaSi=1,MaAlbum=1 },
                new BaiHat(){TenBaiHat="BAI HAT 2",LuotNghe=1,TinhTrangBaiHat=TinhTrangBaiHat.Active,MoreImage="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg" ,Url="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg",MaCaSi=1,MaAlbum=2 },
                new BaiHat(){TenBaiHat="BAI HAT 3",LuotNghe=1,TinhTrangBaiHat=TinhTrangBaiHat.Active,MoreImage="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg" ,Url="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg",MaCaSi=2,MaAlbum=3 },
                new BaiHat(){TenBaiHat="BAI HAT 4",LuotNghe=1,TinhTrangBaiHat=TinhTrangBaiHat.Active,MoreImage="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg" ,Url="https://photo-resize-zmp3.zadn.vn/w94h94_jpeg/cover/4/d/6/2/4d62b014dddf2702af85e1d14d5c0a0b.jpg",MaCaSi=1,MaAlbum=1 }
            };
                context.BaiHats.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}
