using App.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Service.Music
{
    public interface IBaiHatService
    {
        BaiHat Add(BaiHat bh);
        IQueryable<BaiHat> GetAll(string[] includes = null);
        IQueryable<BaiHat> GetMulti(Expression<Func<BaiHat, bool>> predicate, string[] includes = null);
        BaiHat GetSingleById(int id);
        BaiHat Delete(int id);
    }
}
