namespace Web.Ej2
{
    public class PhotoBook
    {
        private int NumPages {  get; set; }
        public int Id { get; set; }

        public static int genId = 1;

        public PhotoBook(int cantPag = 16) 
        {
            NumPages = cantPag;
            Id = genId++;
        }

        public int GetNumberPages() 
        { 
            return NumPages; 
        }
    }
}
