using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.Entity.Models
{
    public class OrderTbl
    {
        public string Id { get; set; }
        public string Store { get; set; }
        public int TotalWeight { get; set; }
        public string CustomerPhone { get; set; }
        public string Status { get; set; }
        public double? CreateDate { get; set; }
        public double? ModifyDate{ get; set; }
    }
}
