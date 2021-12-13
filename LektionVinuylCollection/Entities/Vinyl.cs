using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LektionVinuylCollection.Entities
{
    public class Vinyl
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [ForeignKey("Artist")]
        public int ArtistID { get; set; }

        public string Artist { get; set; }

        //[Required] - commented afer relation b/w tables lesson
        // public string Artist { get; set; }

        public DateTime Created { get; set; }
    }
}
