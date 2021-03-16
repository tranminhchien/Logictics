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
        private IStoreRepo storeRepo;
        private ICategoryProductRepo categoryProductRepo;
        private IUserRepo userRepo;
        private IOrderDetailRepo orderDetailRepo;

        public OrderService(IOrderRepo orderRepo, IStoreRepo storeRepo, ICategoryProductRepo categoryProductRepo, IUserRepo userRepo, IOrderDetailRepo orderDetailRepo)
        {
            this.orderRepo = orderRepo;
            this.storeRepo = storeRepo;
            this.categoryProductRepo = categoryProductRepo;
            this.userRepo = userRepo;
            this.orderDetailRepo = orderDetailRepo;
        }

        public List<OrderViewModel> GetListActive()
        {
            var result = new List<OrderViewModel>();
            var listOrder = orderRepo.GetAll().ToList();
            var listCategoryProduct = categoryProductRepo.GetAll().ToList();
            var listStore = storeRepo.GetAll().ToList();
            var listUser = userRepo.GetAll().ToList();
            var listOrderDetail = orderDetailRepo.GetAll().ToList();

            foreach(var item in listOrder)
            {
                var category = listCategoryProduct.FirstOrDefault(c => c.Id == item.CategoryId);
                var store = listStore.FirstOrDefault(s => s.Id == item.StoreId);
                var sender = listUser.FirstOrDefault(u => u.Id == item.SenderId);
                var recipient = listUser.FirstOrDefault(u => u.Id == item.RecipientId);
                var orderDetail = listOrderDetail.Where(o => o.OrderId == item.Id);
                var customerConfirm = listUser.FirstOrDefault(u => u.Id == item.CustomerConfirmId);

                var orderVM = new OrderViewModel();
                orderVM.MapOrderTblToOrderViewModel(item, category, store, sender, recipient, customerConfirm, orderDetail);

                result.Add(orderVM);
            }

            return result;
        }
    }
}
