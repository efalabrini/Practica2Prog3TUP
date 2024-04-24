using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Ej2BigPhotoBookController : ControllerBase
    {

        [HttpGet()]
        public int Get([FromQuery] int? numPages)
        {
            BigPhotoBook photoBook;
            var photoBooksList = PhotoBooksListInstance.List;

            if (numPages == null)
            {
                photoBook = new BigPhotoBook();
            }
            else
            {
                photoBook = new BigPhotoBook(numPages.Value);
            }

            photoBooksList.AddPhotoBook(new PhotoBook());
            return photoBooksList.CountPhotoBooks();
        }
    }
}
