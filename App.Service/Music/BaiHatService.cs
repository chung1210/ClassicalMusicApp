using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Data.Infrastructure;
using App.Model.Model;

namespace App.Service.Music
{
    public class BaiHatService : IBaiHatService
    {
        IRepository<BaiHat> _bhRepository;
        IUnitOfWork _unitOfWork;
        public BaiHatService(IRepository<BaiHat> bhRepository)
        {
            _bhRepository = bhRepository;
        }
        public BaiHat Add(BaiHat bh)
        {
            return _bhRepository.Add(bh);
        }
    }
}
