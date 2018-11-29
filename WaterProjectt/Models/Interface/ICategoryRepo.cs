using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterProjectt.Models.Interface
{
    interface ICategoryRepo
    {
        Task<IEnumerable<MCategory>> GetMCategories();
    }
}
