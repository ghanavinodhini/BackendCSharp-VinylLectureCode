using System;
using System.Collections.Generic;
using System.Linq;
using LektionVinuylCollection.DTOs;
using LektionVinuylCollection.Entities;

namespace LektionVinuylCollection.Repositories
{
    public class VinylRepo : IVinylRepo

        
    {
        //private List<Vinyl> _collection; - commented after setting up Migrations and Table creation in MYSql Workbench to eliminate hard coded data values to fetch in API
        private ApplicationContext _db; // - this variable name can be context also

        public VinylRepo(ApplicationContext context)
        {
            //_collection = populateVinylData();- commented after setting up Migrations and Table creation in MYSql Workbench to eliminate hard coded data values to fetch in API
            _db = context;
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
            //Vinyl vinyl = _collection.Find(vinyl => vinyl.Id == id);- commented after setting up Migrations and Table creation in MYSql Workbench to eliminate hard coded data values to fetch in API
            Vinyl vinyl = _db.Vinyls.Find(id);//-Passing column name 'id' from table
            return vinyl;
        }

        public List<Vinyl> GetAll()
        {
            // return _collection;- commented after setting up Migrations and Table creation in MYSql Workbench to eliminate hard coded data values to fetch in API
            return _db.Vinyls.ToList(); //-ToList() is given to convert DbContext to List
        }

        //public Vinyl CreateVinyl(Vinyl vinyl) - used without creating CreateVinylDTO
        public Vinyl CreateVinyl(CreateVinylDTO createdVinylDTO)
        {
            Vinyl vinyl = new Vinyl(); //used this line after creating CreateVinylDTO

            vinyl.Created = DateTime.Now;
            vinyl.Artist = createdVinylDTO.Artist; //These 2 lines are added after creating migrations and Db in Mysql
            vinyl.Title = createdVinylDTO.Title;

            // vinyl.Id = _collection.Max(x => x.Id) + 1; - These 2 lines commented after setting up Migrations and Table creation in MYSql Workbench to eliminate hard coded data values to fetch in API
            //_collection.Add(vinyl);

            _db.Vinyls.Add(vinyl); //- "Vinyls" is WeatherForecast <DbSet> variable created in ApplicationContext file.
            _db.SaveChanges(); //Explicitly say to Db context to save DB changes
            return vinyl;
        }

        public Vinyl UpdateVinyl(Vinyl vinyl, int id)
        {
            //Vinyl existingVinyl = _collection.FirstOrDefault(x => x.Id == vinyl.Id);
            //Vinyl existingVinyl = _collection.FirstOrDefault(x => x.Id == id);- commented after setting up Migrations and Table creation in MYSql Workbench to eliminate hard coded data values to fetch in API
            Vinyl existingVinyl = _db.Vinyls.FirstOrDefault(x => x.Id == id);
            if (existingVinyl is not null)
            {
                existingVinyl.Title = vinyl.Title;
                existingVinyl.Artist = vinyl.Artist;
            }
            _db.SaveChanges(); //- Save change in DB after update
            return existingVinyl;

           /* var index = _collection.FindIndex(exVinyl => exVinyl.Id == vinyl.Id);
            _collection[index] = vinyl; - another method to update using index*/
         }

        public void DeleteVinyl(int id)
        {
            /*Vinyl vinyl = _collection.FirstOrDefault(x => x.Id == id);
            _collection.Remove(vinyl);*/
            // _collection.Remove(GetByID(id));-- commented after setting up Migrations and Table creation in MYSql Workbench to eliminate hard coded data values to fetch in API
            _db.Vinyls.Remove(GetByID(id));
            _db.SaveChanges(); //Save Changes in DB after each CRUD opeartion
        }
    }
}
