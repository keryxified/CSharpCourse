using Lesson10Store.Data;
using Lesson10Store.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson10Store.Controllers
{
    [ApiController]
    [ApiExplorerSettings(GroupName = "sportstore")]
    [Route("api/[controller]")]
    public class SportStoreController : Controller
    {
        private readonly SportStoreItemsContext _dbSContext;

        public SportStoreController(SportStoreItemsContext _context)
        {
            _dbSContext = _context;
        }

        [HttpGet(Name = "GetSportStore")]
        //[Route("Products")]
        protected async Task<IActionResult> GetUsers()
        {
            try
            {
                List<Product> listProducts = _dbSContext.Products.ToList();
                if (listProducts != null)
                {
                    return Ok(listProducts);
                }
                return Ok("Products are empty");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}