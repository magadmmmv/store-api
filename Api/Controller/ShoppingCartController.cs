using Api.Data;
using Api.Model;
using Api.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Api.Controller
{
    public class ShoppingCartController : StoreController
    {
        private readonly ShoppingCartService shoppingCartService;

        public ShoppingCartController(
            AppDbContext dbContext,
            ShoppingCartService shoppingCartService)
            : base(dbContext)
        {
            this.shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseServer>> AppendOrUpdateItemInCart(
            string userId, int productId, int updateQuantity)
        {
            Product? product = await dbContext
                .Products
                .FindAsync(productId);

            if (product == null)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = { "Такого товара не найдено" }
                });
            }

            AppUser? appUser = await dbContext
                .AppUsers
                .FindAsync(userId);

            if (appUser == null)
            {
                return NotFound(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.NotFound,
                    ErrorMessage = { "Пользователь не существует" }
                });
            }

            ShoppingCart? shoppingCart = await shoppingCartService
                .GetShoppingCartAsync(userId);

            if (shoppingCart == null && updateQuantity > 0)
            {
                await shoppingCartService.CreateNewCartAsync(
                    userId, productId, updateQuantity);
            }

            if (shoppingCart != null)
            {
                await shoppingCartService.UpdateExistingCartAsync(
                    shoppingCart, productId, updateQuantity);
            }

            return Ok(new ResponseServer
            {
                StatusCode = HttpStatusCode.OK,
                Result = "Операция выполнена успешно"
            });
        }

        [HttpGet]
        public async Task<ActionResult<ResponseServer>> GetShoppingCart(
            string userId)
        {
            try
            {
                ShoppingCart? shoppingCart = await shoppingCartService
                    .GetShoppingCartAsync(userId);

                if (shoppingCart != null)
                {
                    return Ok(new ResponseServer
                    {
                        StatusCode = HttpStatusCode.OK,
                        Result = shoppingCart
                    });
                }
                else
                {
                    return NotFound(new ResponseServer
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = {"Корзина не найдена"}
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Result = "Ошибка получения корзины" + ex.Message
                });
            }
        }
    }
}
