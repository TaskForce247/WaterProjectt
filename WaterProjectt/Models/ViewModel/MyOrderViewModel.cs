using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaterProjectt.Models.ViewModel
{
    public class MyOrderViewModel
    {
        public OrderDto OrderPlaceDetails { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlacedTime { get; set; }
        public IEnumerable<MyCakeOrderInfo> CakeOrderInfos { get; set; }
}