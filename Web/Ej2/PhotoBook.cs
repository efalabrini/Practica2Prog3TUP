namespace Web.Ej2
{
    public class PhotoBook
    {
        private int numPages {  get; set; }

        public PhotoBook(int cantPag = 16) 
        {
            numPages = cantPag;
        }

        public int GetNumberPages() 
        { 
            return numPages; 
        }
    }
}
