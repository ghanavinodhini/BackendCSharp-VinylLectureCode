using System;
using System.Collections.Generic;
using System.Linq;
using LektionVinuylCollection.Entities;

namespace LektionVinuylCollection.DTOs
{
    public class VinylDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        // public string Artist { get; set; } - commented after relation b/w tables
        public BasicArtistDTO Artist { get; set; }
        //public int ArtistID { get; set; } - commented after creating BasicArtistDTO
    }

    //Created this class after relation b/w tables
    public static class VinylDtoExtensions
    {
        //VinylDTO dto = vinyl.MapToVinylDTO()
        //MapToVinylDTO(vinyl) - Alternative for this 2 functions below

        public static VinylDTO MapToVinylDTO(this Vinyl vinyl)
        {
            return new VinylDTO
            {
                Id = vinyl.Id,
                // ArtistID = vinyl.ArtistID,- commented after creating BasicArtistDTO
                Artist = vinyl.Artist.MapToBasicArtistDTO(),
                Title = vinyl.Title,
            };
        }

        public static List<VinylDTO> MapToVinylDTOs(this List<Vinyl> vinyls)
        {
            return vinyls.Select(v => v.MapToVinylDTO()).ToList();
        }
    }
}


