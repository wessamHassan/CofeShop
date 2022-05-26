using CofeShop.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CofeShop.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ProductController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            return await applicationDbContext.Products.ToListAsync();
        }

        [HttpGet("{id}", Name ="GetProduct")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            return await applicationDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public decimal CalcTotalPrice(Order order)
        {
            decimal totalPrice = 0;
            decimal itemPrice = 0;
           
                itemPrice = applicationDbContext.Products.FirstOrDefaultAsync(x => x.Id == order.ProductId).Result.Price;
                totalPrice += itemPrice * order.Count;

            
            return totalPrice;
        }
        //public decimal CalcTotalPrice(List<Order> orders)
        //{
        //    decimal totalPrice = 0;
        //    decimal itemPrice = 0;
        //    foreach (Order order in orders)
        //    {
        //        itemPrice = applicationDbContext.Products.FirstOrDefaultAsync(x => x.Id == order.ProductId).Result.Price;
        //        totalPrice += itemPrice * order.Count;

        //    }
        //    return totalPrice;
        //}
    }
}
