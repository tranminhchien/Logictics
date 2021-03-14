using Logictics.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Utils;

namespace Logictics.Service.ViewModel
{
    public class OrderViewModel
    {
        public string Id { get; set; } = "";

        public double? TotalWeight { get; set; } = 0;

        public string Store { get; set; } = "";

        public string CustomerPhone { get; set; } = "";

        public string Status { get; set; } = "";

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }
    

        public void MapOrderTblToOrderViewModel(OrderTbl order)
        {
            this.Id = order.Id;
            this.TotalWeight = order.TotalWeight;
            this.Store = order.Store;
            this.CustomerPhone = order.CustomerPhone;
            this.Status = order.Status;
            this.CreateDate = TimestampStaicClas.ConvertToDatetime(order.CreateDate);
            this.ModifyDate = TimestampStaicClas.ConvertToDatetime(order.ModifyDate);
        }
    }
}
