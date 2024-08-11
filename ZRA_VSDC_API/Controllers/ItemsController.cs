using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ZRA_VSDC_API.Models;
using ZRA_VSDC_API.Models.Dto;

namespace ZRA_VSDC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Item>> GetItems(){
            return Ok(Data.items);
        }


        [HttpGet("{TPin: int}", Name = "GetItem" )]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<Item> GetItem(int TPin){

            var item = Data.items.FirstOrDefault(u => u.TPin == TPin);

            return Ok(item);
        }

        [HttpPost]
        public ActionResult<Item> SaveItem([FromBody]Item item){

            

                 return CreatedAtRoute("GetItem", new { TPin = item.TPin}, item);

            
        }
        
    }
}
