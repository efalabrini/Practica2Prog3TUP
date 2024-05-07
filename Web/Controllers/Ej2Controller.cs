using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web.Ej2;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        static List<PhotoBook> photoBooks = new List<PhotoBook>();

        [HttpPost("[action]")]
        public ActionResult<string> StandardAlbum([FromBody] int pages = 16)
        {
            photoBooks.Add(new PhotoBook(pages));
            return Ok($"se creo el album estandar con {pages} paginas");
        }

        [HttpPost("[action]")]
        public ActionResult<string> BigAlbum()
        {
            photoBooks.Add(new BigPhotoBook());
            return Ok("se creo el album grande con 64 paginas");
        }

        [HttpGet("[action]/{id}")]
        public ActionResult<int> GetNumberOfPages(int id)
        {
            PhotoBook album = photoBooks.Find(p => p.id == id);

            if (album != null)
            {
                return Ok(album.GetNumberPages());
            }
            else
            {
                return NotFound($"no se encontro un album con el id {id}");
            }
        }
        [HttpGet("[action]")]
         public ActionResult<List<PhotoBook>> getAllBooks()
        {
            return photoBooks;
        }
    }
}















