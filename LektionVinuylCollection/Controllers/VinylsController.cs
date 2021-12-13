using System;
using System.Collections.Generic;
using System.Linq;
using LektionVinuylCollection.DTOs;
using LektionVinuylCollection.Entities;
using LektionVinuylCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LektionVinuylCollection.Controllers
{
    [ApiController]
    [Route("api/vinyl")]
    public class VinylsController:ControllerBase
    {
        private readonly IVinylRepo _repo;

        public VinylsController(IVinylRepo repo)
        {
            _repo = repo;
        }

        // GET /api/vinyl
        [HttpGet]
        [Route("")]
        //public List<Vinyl> GetVinyls()
          public IActionResult GetVinyls()
        {
            //List<Vinyl> vinyls = _repo.GetAll(); //used without VinylDTO
            var vinylsDTO = _repo.GetAll().Select(v => new VinylDTO
            {
                Id = v.Id,
                Artist = v.Artist,
                Title = v.Title
            }).OrderBy(x=>x.Title);
            return Ok(vinylsDTO);
            //return Ok(vinyls); //used without VinylDTO
        }


        // GET /api/vinyl/{id}
        [HttpGet]
        [Route("{id}")]
        //public Vinyl GetVinylByID(int id)
        public IActionResult GetVinylByID(int id)
        {
            Vinyl vinyl = _repo.GetByID(id);
            if(vinyl is null)
            {
                return NotFound($"Vinyl Id {id} is Not Found");
            }

            /*VinylDTO vinylDTO = new VinylDTO
            {
                Id = vinyl.Id,
                Artist = vinyl.Artist,
                Title = vinyl.Title,
            };*/ //used without creating MapVinylToVinylDTO function

            VinylDTO vinylDTO = MapVinylToVinylDTO(vinyl);
            return Ok(vinylDTO);
            //return Ok(vinyl); //used with IActionREsult without creating VinylDTO
            //return _repo.GetByID(id); //used without IAcionResult
        }

        [HttpPost]
        [Route("")]
        //public Vinyl CreateVinyl([FromBody]Vinyl vinyl)
        //public IActionResult CreateVinyl([FromBody] Vinyl vinyl) - used without creating CreateVinylDTO
        public IActionResult CreateVinyl([FromBody] CreateVinylDTO createVinylDTO)
        {
            //Vinyl createdVinyl = _repo.CreateVinyl(vinyl) - used before creating CreateVinylDTO;

            Vinyl createdVinyl = _repo.CreateVinyl(createVinylDTO);
            /* VinylDTO vinylDTO = new VinylDTO
             {
                 Id = createdVinyl.Id,
                 Artist = createdVinyl.Artist,
                 Title = createdVinyl.Title,
             };*/ //used without creating MapVinylToVinylDTO function


            VinylDTO vinylDTO = MapVinylToVinylDTO(createdVinyl);
            return CreatedAtAction(
                nameof(GetVinylByID),
                new { id = vinylDTO.Id },
                vinylDTO);
            //return CreatedAtAction(nameof(GetVinylByID),new { id = createdVinyl.Id },createdVinyl); //used without VinylDTO
            //return createdVinyl;
        }

        [HttpPut]
        [Route("{id}")]
        //public Vinyl UpdateVinyl([FromBody]Vinyl vinyl)
        public IActionResult UpdateVinyl([FromBody] Vinyl vinyl, int id)
        {
            Vinyl updatedVinyl = _repo.UpdateVinyl(vinyl,id);
            VinylDTO vinylDTO = MapVinylToVinylDTO(updatedVinyl);
            return Ok(vinylDTO);
            //return Ok(updatedVinyl); //used without creating VinylDTO
        }

        [HttpDelete]
        [Route("{id}")]
        //public void DeleteVinyl(int id)
        public IActionResult DeleteVinyl(int id)
        {
            _repo.DeleteVinyl(id);
            return NoContent();
        }

        private VinylDTO MapVinylToVinylDTO(Vinyl vinyl)
        {
            return new VinylDTO
            {
                Id = vinyl.Id,
                Artist = vinyl.Artist,
                Title = vinyl.Title,
            };
        }

    }
}
