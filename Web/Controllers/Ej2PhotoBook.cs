using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Ej2PhotoBookController : ControllerBase
    {
        
        [HttpGet()]
        public int Get([FromQuery] int? numPages)
        {
            PhotoBook photoBook;
            var photoBooksList = PhotoBooksListInstance.List;
            
            if (numPages == null)
            {
                photoBook = new PhotoBook();
            }else 
            { 
                photoBook = new PhotoBook(numPages.Value); 
            }

            photoBooksList.AddPhotoBook(new PhotoBook());
            return photoBook.GetNumberPages();
        }
    }
}
