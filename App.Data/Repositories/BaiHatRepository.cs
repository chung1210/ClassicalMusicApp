using App.Data.Infrastructure;
using App.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repositories
{

    public interface IBaiHatRepository : IRepository<BaiHat>
    {
    }

    public class BaiHatRepository : RepositoryBase<BaiHat>, IBaiHatRepository
    {
        public BaiHatRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
