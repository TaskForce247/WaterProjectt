using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaterProjectt.Models
{
    public class MOrderDetail
    {

        public int Id { get; set; }

        public string MachineName { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public MOrder MOrder { get; set; }
        
    }
}