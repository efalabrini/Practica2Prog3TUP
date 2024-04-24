using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Ej2NumPagesController : ControllerBase
    {

        [HttpGet()]
        public int Get([FromQuery] int index)
        {
            var photoBooksList = PhotoBooksListInstance.List;

            return photoBooksList.GetPhotoBookPages(index);
        }
    }
}
