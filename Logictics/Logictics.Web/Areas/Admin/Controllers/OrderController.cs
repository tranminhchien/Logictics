using Common.Utils;
using Logictics.Service.Core;
using Logictics.Service.ViewModel;
using Logictics.Web.Auth;
using Logictics.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logictics.Web.Areas.Admin.Controllers
{

    [Area(Role.Admin)]
    //[LogicticsAuthorize(Role.Admin)]
    public class OrderController : Controller
    {
        #region DI
        private IOrderService orderService;
        private IOrderDetailService orderDetailService;
        private ITimestampUtil timestampUtil;

        public OrderController(IOrderService orderService, IOrderDetailService orderDetailService, ITimestampUtil timestampUtil)
        {
            this.orderService = orderService;
            this.orderDetailService = orderDetailService;
            this.timestampUtil = timestampUtil;
        }


        #endregion DI

        // GET: OrderController
        public ActionResult Index()
        {
            var model = orderService.GetListActive();
            return View(model);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            //Fake ListCategory
            var listCategory = new List<ProductCategoryViewModel>();
            var categoryA = new ProductCategoryViewModel()
            {
                Id = "1",
                Name = "Product A"
            };
            var categoryB = new ProductCategoryViewModel()
            {
                Id = "2",
                Name = "Product B"
            };
            listCategory.Add(categoryA);
            listCategory.Add(categoryB);

            var listStore = new List<OrderStoreViewModel>();
            var storeA = new OrderStoreViewModel()
            {
                Id = "1",
                Name = "Store A"
            };
            var storeB = new OrderStoreViewModel()
            {
                Id = "2",
                Name = "Store B"
            };
            listStore.Add(storeA);
            listStore.Add(storeB);

            ViewBag.ListCategory = new SelectList(listCategory, "Name", "Name");
            ViewBag.ListStore = new SelectList(listStore, "Name", "Name");

            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }

}