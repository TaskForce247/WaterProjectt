using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterProjectt.Models.Interface
{
    interface IShoppingCartService
    {
        string Id { get; set; }
        IEnumerable<MShoppingCartItem> MShoppingCartItems { get; set; }

        Task<int> AddToCartAsync(Machine machine, int qty = 1);
        Task ClearCartAsync();
        Task<IEnumerable<MShoppingCartItem>> GetShoppingCartItemsAsync();
        Task<int> RemoveFromCartAsync(Machine machine);
        Task<(int ItemCount, decimal TotalAmmount)> GetCartCountAndTotalAmmountAsync();
    }
}
