namespace Web.Ej2
{
    public class PhotoBooksList
    {
        public List<PhotoBook> photoBooksList { get; set; } = new List<PhotoBook>();

        public void AddPhotoBook(PhotoBook photoBook)
        {
            photoBooksList.Add(photoBook);
        } 

        public int CountPhotoBooks()
        {
            return photoBooksList.Count();
        }

        public int GetPhotoBookPages(int index) 
        {
            return photoBooksList[index].GetNumberPages();
        }
    }


}
