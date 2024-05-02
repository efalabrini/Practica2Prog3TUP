using System.Collections.Generic;
using Web.Ej2;
using static System.Reflection.Metadata.BlobBuilder;

public static class Database
{
    public static List<PhotoBook> Books { get; } = new List<PhotoBook> //En que momento se genera esta lista?
    {
        new BigPhotoBook(),
            
        new PhotoBook(),
            
        new PhotoBook(24),
            
        new BigPhotoBook(96),
            
        new PhotoBook(17),

        new BigPhotoBook(134)
            
    };
}

