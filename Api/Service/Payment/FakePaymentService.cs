using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Api.Common.SharedData;
using System.Net;

namespace Api.Service.Payment
{
    public class FakePaymentService : IPaymentService
    {
        private readonly AppDbContext dbContext;

        public FakePaymentService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<ActionResult<ResponseServer>> HandlePaymentAsync(
            string userId, int orderHeaderId, string cardNumber)
        {
            ShoppingCart? shoppingCart = await dbContext
                .ShoppingCarts
                .Include(u => u.CartItems)
                .ThenInclude(u => u.Product)
                .FirstOrDefaultAsync(u => u.UserId == userId);

            if (shoppingCart == null
                || shoppingCart.CartItems == null
                || shoppingCart.CartItems.Count == 0)
            {
                return new BadRequestObjectResult(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = {"Корзина пуста или не найдена"}
                });
            }

            shoppingCart.TotalAmount = shoppingCart
                .CartItems
                .Sum(u => u.Quantity * u.Product.Price);

            OrderHeader? orderHeader = await dbContext
                .OrderHeaders
                .FindAsync(orderHeaderId);

            if (orderHeader == null)
            {
                return new BadRequestObjectResult(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = { "Такого заказа не существует" }
                });
            }

            await Task.Delay(5000);

            PaymentResponse paymentResponse;

            if (cardNumber == "1111 2222 3333 4444")
            {
                paymentResponse = new PaymentResponse
                {
                    Success = true,
                    IntentId = "fake_intent_id",
                    Secret = "fake_secret"
                };
            }
            else
            {
                paymentResponse = new PaymentResponse
                {
                    Success = false,
                    IntentId = string.Empty,
                    Secret = string.Empty,
                    ErrorMessage = "Недействительная карта"
                };
            }

            if (!paymentResponse.Success)
            {
                return new BadRequestObjectResult(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = { paymentResponse.ErrorMessage },
                    Result = paymentResponse                    
                });
            }
            else
            {
                orderHeader.Status = OrderStatus.ReadyToShip;
            }

            await dbContext.SaveChangesAsync();

            return new OkObjectResult(new ResponseServer
            {
                StatusCode = HttpStatusCode.OK,
                Result = orderHeader
            });
        }
    }
}
