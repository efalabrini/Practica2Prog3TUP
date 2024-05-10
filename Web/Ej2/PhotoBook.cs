namespace Web.Ej2
{
    public class PhotoBook
    {
        protected int NumPages { get; set; }
        public int Id { get; }
        public static int Cont = 0;

        public PhotoBook() : this (16)
        {            
        }

        public PhotoBook(int numPages)
        {
            NumPages=numPages;
            Id = Cont;
            Cont++;
        }
        
        public int GetNumberPages()
        {
            return NumPages;
        }
    }
}
