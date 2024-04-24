namespace Web.Ej2
{
    public class PhotoBook
    {   
        public PhotoBook() 
        {
            NumPages = 16;
        }

        public PhotoBook(int numPages)
        {
            NumPages=numPages;
        }
        protected int NumPages { get; set; }

        public int GetNumberPages()
        {
            return NumPages;
        }
    }
}
