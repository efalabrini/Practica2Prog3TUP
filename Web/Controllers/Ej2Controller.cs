using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Web.Ej2;


namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : ControllerBase
    {
        [HttpGet("[action]")]
        public ActionResult<string> GetBookStandar([FromQuery] int numPages)
        {
            var book1 = new PhotoBook(numPages);

            if (numPages == 0)
            {
                book1 = new PhotoBook();
            }

            return $"El libro tiene: {book1.GetNumberPages()}";
        }


        [HttpGet("[action]")]
        public string GetBigBook()
        {
            var book2 = new BigPhotoBook();

            return $"El libro tiene: {book2.GetNumberPages()}";
        }


        [HttpGet("[action]")]
        public string GetNumPages([FromQuery] int id) 
        {
            /*var books = new List<PhotoBook>();

            var book3 = new BigPhotoBook();
            books.Add(book3);

            var book4 = new PhotoBook();
            books.Add(book4);

            var book5 = new PhotoBook(24);     esta fue la primer idea pero se me pisaban los id cada vez que consultaba uno nuevo
                                               ya que se generaban nuevos objt sobre las mismas var y era una lista diferente a la hora de una segunda busqueda
            books.Add(book5);

            var book6 = new BigPhotoBook(96);
            books.Add(book6);

            var book7 = new PhotoBook(17);
            books.Add(book7);*/

            PhotoBook.genId = 1;  // reinicie el id ya que si primero hacia consultas
                                  // en los otros endpoints el id aumentaba y yo no sabia con que id se generaban los libros de la lista

            foreach (var book in Database.Books) //se crea aca la lista de libros?
            {
                if (book.Id == id)
                {
                    return $"El libro con el id [{id}] tiene {book.GetNumberPages()} paginas";
                }
            }
            
            return "El Id es incorrecto o el libro no existe";

        }
    }
}
