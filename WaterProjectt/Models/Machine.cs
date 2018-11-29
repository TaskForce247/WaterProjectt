using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaterProjectt.Models
{
    public class Machine
    {
            public int Id { get; set; }
            public string Name { get; set; }

            public string ShortDescription { get; set; }

            public string ImageUrl { get; set; }

            public string LongDescription { get; set; }

            public decimal Price { get; set; }

            public int stock { get; set; }

            public int CategoryId { get; set; }
            public MCategory MCategory { get; set; }
        }
    
}