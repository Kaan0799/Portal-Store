using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrate
{
    public class SkıuManager : ISkuService
    {
        ISkuDal _skuDal;

        public SkıuManager(ISkuDal skuDal)
        {
            _skuDal = skuDal;
        }

        public Sku GetById(int id)
        {
            return _skuDal.GetById(id);
        }

        public List<Sku> GetList()
        {
            return _skuDal.GetListAll();
        }

        public void TAdd(Sku t)
        {
            _skuDal.Insert(t);
        }

        public void TDelete(Sku t)
        {
            _skuDal.Delete(t);
        }

        public void TUpdate(Sku t)
        {
            _skuDal.Update(t);
        }
    }
}
