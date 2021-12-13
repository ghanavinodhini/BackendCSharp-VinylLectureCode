using System;
using System.Collections.Generic;
using LektionVinuylCollection.DTOs;
using LektionVinuylCollection.Entities;

namespace LektionVinuylCollection.Repositories
{
    public interface IVinylRepo
    {
        Vinyl GetByID(int id);
        List<Vinyl> GetAll();
        //Vinyl CreateVinyl(Vinyl vinyl); -used without creating CreateVinylDTO
        Vinyl CreateVinyl(CreateVinylDTO vinyl);
        Vinyl UpdateVinyl(Vinyl vinyl, int id);
        void DeleteVinyl(int id);
    }
}
