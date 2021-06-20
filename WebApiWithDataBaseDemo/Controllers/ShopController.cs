using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiWithDataBaseDemo.Data;

namespace WebApiWithDataBaseDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly DataContext _context;

        public ShopController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
