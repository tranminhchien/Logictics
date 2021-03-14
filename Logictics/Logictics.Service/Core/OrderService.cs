using Logictics.DAL.Repository;
using Logictics.Entity.Models;
using Logictics.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logictics.Service.Core
{
    public interface IOrderService
    {
        List<OrderViewModel> GetListActive();
    }

    public class OrderService : IOrderService
    {
        private IOrderRepo orderRepo;

        public OrderService(IOrderRepo orderRepo)
        {
            this.orderRepo = orderRepo;
        }

        public List<OrderViewModel> GetListActive()
        {
            var listOrder = orderRepo.GetAll().ToList();
            var result = new List<OrderViewModel>();

            foreach(var item in listOrder)
            {
                var orderVM = new OrderViewModel();
                orderVM.MapOrderTblToOrderViewModel(item);
                result.Add(orderVM);
            }

            return result;
        }
    }
}
