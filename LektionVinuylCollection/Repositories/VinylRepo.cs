using System;
using System.Collections.Generic;
using System.Linq;
using LektionVinuylCollection.DTOs;
using LektionVinuylCollection.Entities;

namespace LektionVinuylCollection.Repositories
{
    public class VinylRepo : IVinylRepo

        
    {
        private List<Vinyl> _collection;

        public VinylRepo()
        {
            _collection = populateVinylData();
        }

        private List<Vinyl> populateVinylData()
        {
            return new List<Vinyl>
            {
            new Vinyl { Id = 1, Artist = "Bob Dylan", Title = "New Morning",Created=DateTime.Now, },
            new Vinyl { Id = 2, Artist = "Leonard Cohen", Title = "Ten New Songs",Created=DateTime.Now, },
            new Vinyl { Id = 3, Artist = "Flamingokvintetten", Title = "Flamingokvintetten 12",Created=DateTime.Now, },
            };
        }

        

        public Vinyl GetByID(int id)
        {
            Vinyl vinyl = _collection.Find(vinyl => vinyl.Id == id);
            return vinyl;
        }

        public List<Vinyl> GetAll()
        {
            return _collection;
        }

        //public Vinyl CreateVinyl(Vinyl vinyl) - used without creating CreateVinylDTO
        public Vinyl CreateVinyl(CreateVinylDTO createdVinylDTO)
        {
            Vinyl vinyl = new Vinyl(); //used this line after creating CreateVinylDTO
            vinyl.Created = DateTime.Now;
            vinyl.Id = _collection.Max(x => x.Id) + 1;
            _collection.Add(vinyl);
            return vinyl;
        }

        public Vinyl UpdateVinyl(Vinyl vinyl)
        {
            Vinyl existingVinyl = _collection.FirstOrDefault(x => x.Id == vinyl.Id);
            if (existingVinyl is not null)
            {
                existingVinyl.Title = vinyl.Title;
                existingVinyl.Artist = vinyl.Artist;
            }
            return existingVinyl;

           /* var index = _collection.FindIndex(exVinyl => exVinyl.Id == vinyl.Id);
            _collection[index] = vinyl; - another method to update using index*/
         }

        public void DeleteVinyl(int id)
        {
            /*Vinyl vinyl = _collection.FirstOrDefault(x => x.Id == id);
            _collection.Remove(vinyl);*/
            _collection.Remove(GetByID(id));
        }
    }
}
