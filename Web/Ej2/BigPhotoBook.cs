namespace Web.Ej2
{
    public class BigPhotoBook : PhotoBook
    {
        public BigPhotoBook() { 
            NumPages = 64;
        }

        public BigPhotoBook(int numPages) :base(numPages) { }
    }
}
