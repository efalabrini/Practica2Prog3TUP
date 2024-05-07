namespace Web.Ej2
{
    public class PhotoBook
    {   
        public static int Cont = 0;

        public PhotoBook() 
        {
            NumPages = 16;
            Id = Cont;
            Cont++;
        }

        public PhotoBook(int numPages)
        {
            NumPages=numPages;
            Id = Cont;
            Cont++;
        }
        protected int NumPages { get; set; }

        public int Id { get; set; }

        public int GetNumberPages()
        {
            return NumPages;
        }
    }
}
