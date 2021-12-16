using System;
namespace LektionVinuylCollection.DTOs
{
    public class CreateVinylDTO
    {
        public string Title { get; set; }
        //public string Artist { get; set; } - commented after relation b/w tables
        public int ArtistID { get; set; }
    }
}
