using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using App.Data.Infrastructure;
using App.Data.Repositories;
using App.Model.Model;

namespace App.Service.Music
{
    public class BaiHatService : IBaiHatService
    {
        IRepository<BaiHat> _bhRepository;
        IUnitOfWork _unitOfWork;
        public BaiHatService(IRepository<BaiHat> bhRepository, IUnitOfWork unitOfWork)
        {
            _bhRepository = bhRepository;
            _unitOfWork = unitOfWork;
        }
        public BaiHat Add(BaiHat bh)
        {
            var baihat = _bhRepository.Add(bh);
            _unitOfWork.Commit(); //cap nhat vao database
            return baihat;
        }

        public BaiHat Delete(int id)
        {
            var baihat = _bhRepository.Delete(id);
            _unitOfWork.Commit(); //cap nhat vao database
            return baihat;
        }

        public IQueryable<BaiHat> GetAll(string[] includes = null)
        {
            return _bhRepository.GetAll(includes);
        }

        public IQueryable<BaiHat> GetMulti(Expression<Func<BaiHat, bool>> predicate, string[] includes = null)
        {
            return _bhRepository.GetMulti(predicate, includes);
        }

        public BaiHat GetSingleById(int id)
        {
            return _bhRepository.GetSingleById(id);
        }
    }
}
