using Logictics.DAL.Repository;
using Logictics.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logictics.Service.Core
{
    public interface IOrderDetailService
    {
        List<OrderDetailTbl> GetListOrderDetail(string orderId);
    }

    public class OrderDetailService : IOrderDetailService
    {
        private IOrderDetailRepo orderDetailRepo;

        public OrderDetailService(IOrderDetailRepo orderDetailRepo)
        {
            this.orderDetailRepo = orderDetailRepo;
        }

        public List<OrderDetailTbl> GetListOrderDetail(string orderId)
        {
            return orderDetailRepo.GetAll().Where(o => o.OrderId == orderId).ToList();
        }
    }
}
