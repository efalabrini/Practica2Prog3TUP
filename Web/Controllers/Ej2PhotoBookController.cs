using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Ej2PhotoBookController : ControllerBase
    {
        
        [HttpPost("[action]")]
        public void CreatePhotoBook([FromQuery] int numPages)
        {
            PhotoBook photoBook;
            
            if (numPages == 0)
            {
                photoBook = new PhotoBook();
            }else 
            { 
                photoBook = new PhotoBook(numPages); 
            }

            PhotoBooksListInstance.List.Add(photoBook);
        }

        [HttpPost("[action]")]
        public void CreateBigPhotoBook([FromQuery] int? numPages)
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

            photoBooksList.Add(photoBook);
        }

        [HttpGet("[action]")]
        public int NumPages([FromQuery] int id)
        {
            var pages = from photobook in PhotoBooksListInstance.List
                        where photobook.Id == id
                        select photobook.GetNumberPages();


            return pages.FirstOrDefault();
        }
    }
}
