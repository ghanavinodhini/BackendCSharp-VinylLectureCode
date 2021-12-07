using System;
namespace LektionVinuylCollection.Entities
{
    public class Vinyl
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public DateTime Created { get; set; }
    }
}
