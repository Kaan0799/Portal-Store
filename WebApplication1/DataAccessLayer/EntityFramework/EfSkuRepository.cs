using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfSkuRepository : GenericRepository<Sku>, ISkuDal
    {
        public List<Sku> GetListWhithCategory()
        {
            using(var c=new Context())
            {
                return c.Skus.Include(x => x.Category).ToList();
            }
        }
    }
}
