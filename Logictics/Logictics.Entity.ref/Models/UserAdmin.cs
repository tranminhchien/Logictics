using System;
using System.Collections.Generic;
using System.Text;

namespace Logictics.Entity.Models
{
    public class UserAdmin
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
    }
}
