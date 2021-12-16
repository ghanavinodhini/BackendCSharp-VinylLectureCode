using System;
using System.Collections.Generic;
using System.Linq;
using LektionVinuylCollection.Entities;

namespace LektionVinuylCollection.DTOs
{
    public class ArtistDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string FavoriteCar { get; set; }

        public List<VinylDTO> Vinyls { get; set; }
    }

    public static class ArtistDTOExtensions
    {
        public static ArtistDTO MapToArtistDTO(this Artist artist)
        {
            return new ArtistDTO
            {
                Id = artist.Id,
                Name = artist.Name,
                FavoriteCar = artist.FavoriteCar,
                Vinyls = artist.Vinyls.MapToVinylDTOs()
            };
        }

        public static List<ArtistDTO> MapToArtistDTOs(this List<Artist> artists)
        {
            return artists.Select(a => a.MapToArtistDTO()).ToList();
        }
    }
}


