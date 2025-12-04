using Api.Data;
using Api.Service;

namespace Api.Controller
{
    public class OrderController : StoreController
    {
        private readonly OrdersService ordersService;

        public OrderController(
            AppDbContext dbContext, 
            OrdersService ordersService) 
            : base(dbContext)
        {
            this.ordersService = ordersService;
        }

    }
}
