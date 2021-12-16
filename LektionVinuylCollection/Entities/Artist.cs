using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LektionVinuylCollection.Entities
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string  Name { get; set; }

        [Required]
        public string FavoriteCar { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public List<Vinyl> Vinyls { get; set; } //added after relation b/w tables lesson

    }
}
