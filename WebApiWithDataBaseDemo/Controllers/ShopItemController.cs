using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiWithDataBaseDemo.Data;
using WebApiWithDataBaseDemo.Models;

namespace WebApiWithDataBaseDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopItemController : ControllerBase
    {
        private readonly DataContext _context;

        public ShopItemController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        [HttpGet]
        public List<ShopItem> GetAll()
        {
            return _context.ShopItems.ToList();
        }

        [HttpPost]
        public void Post(ShopItem item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }
    }
}
