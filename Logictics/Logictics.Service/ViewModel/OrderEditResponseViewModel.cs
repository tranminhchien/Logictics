using Logictics.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.Service.ViewModel
{
    public class OrderEditResponseViewModel
    {
        public OrderTbl orderTbl { get; set; }

        public List<OrderDetailTbl> listOrderDetail { get; set; }
    }
}
