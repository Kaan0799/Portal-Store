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
    public class OrderItemManager : IOrderItemService
    {
        IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }

        public OrderItem GetById(int id)
        {
            return _orderItemDal.GetById(id);
        }

        public List<OrderItem> GetList()
        {
            return _orderItemDal.GetListAll();
        }

        public void TAdd(OrderItem t)
        {
            _orderItemDal.Insert(t);
        }

        public void TDelete(OrderItem t)
        {
            _orderItemDal.Delete(t);
        }

        public void TUpdate(OrderItem t)
        {
            _orderItemDal.Update(t);
        }
    }
}
