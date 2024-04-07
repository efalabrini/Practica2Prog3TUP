using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet()]
        public string Get()
        {
            var book1 = new PhotoBook();
            var book2 = new PhotoBook(24);
            var book3 = new BigPhotoBook();

            return $"El primer libro tiene: {book1.GetNumberPages()}\nEl segundo libro tiene: {book2.GetNumberPages()}\nEl tercer libro tiene: {book3.GetNumberPages()}";
        }
    }
}
