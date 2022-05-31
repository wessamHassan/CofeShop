using CofeShop.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CofeShop.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public OrderController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderDto>>> Get()
        {
            return await applicationDbContext.Orders.ToListAsync();
        }



        [HttpPost]
        public async Task CalcTotalPrice(List<Order> orders)
        {
            decimal totalPrice = 0;
            decimal itemPrice = 0; 
             Product product;
            OrderDto dto = new OrderDto();
            List<OrderDto> ordersList = new List<OrderDto>();
            foreach (Order order in orders)
            {
                product = applicationDbContext.Products.FirstOrDefaultAsync(x => x.Id == order.ProductId).Result;
                itemPrice = product.Price;
                totalPrice = itemPrice * order.Count;
                dto = new OrderDto();
                dto.ItemName = product.Name;
                dto.CountPerItem = order.Count;
                dto.TotalPricePerItem = totalPrice;
                dto.UnitPrice = itemPrice;
                applicationDbContext.Orders.Add(dto);

            }
            await applicationDbContext.SaveChangesAsync();
            //var str = JsonConvert.SerializeObject(ordersList);
            //HttpContext.Session.SetString("key", str);

            
        }

        [HttpDelete("{id}")]
        public async Task DeleteOrder(int id)
        {
            OrderDto order = applicationDbContext.Orders.FirstOrDefaultAsync(x => x.Id == id).Result;
            applicationDbContext.Orders.Remove(order);
            await applicationDbContext.SaveChangesAsync();
        }

    }
}
