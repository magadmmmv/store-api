using Api.Data;
using Api.Model;
using Api.ModelDto;
using Api.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        [HttpPost]
        public async Task<ActionResult<ResponseServer>> CreateOrder(
            [FromBody] OrderHeaderCreateDto orderHeaderCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = {"Неверное состояние модели заказа"}
                });
            }

            try
            {
                var order = await ordersService.CreateOrderAsync(orderHeaderCreateDto);

                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.Created,
                    Result = order
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = {"Невероятная ошибка", ex.Message}
                });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseServer>> GetOrder(int id)
        {
            if (id <= 0)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = { "Неверный идентификатор заказа" }
                });
            }

            try
            {
                var orderHeader = await ordersService.GetOrderByIdAsync(id);

                if (orderHeader == null)
                {
                    return NotFound(new ResponseServer
                    {
                        IsSuccess = false,
                        StatusCode = HttpStatusCode.NotFound,
                        ErrorMessage = { "Заказ не найден" }
                    });
                }

                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.OK,
                    Result = orderHeader
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.BadRequest,
                    ErrorMessage = { "Что-то пошло не так", ex.Message }
                });
            }
        }

        [HttpGet]
        public async Task<ActionResult<ResponseServer>> GetOrdersByUserId(string userId)
        {
            try
            {
                var orderHeaders = await ordersService.GetOrderByUserAsync(userId);
                return Ok(new ResponseServer
                {
                    StatusCode = HttpStatusCode.OK,
                    Result = orderHeaders
                });
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError,
                new ResponseServer
                {
                    IsSuccess = false,
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = {"При обработке возникла проблема", ex.Message}
                });
            }
        }
    }
}
