using System.Collections.Generic;
using System.Linq;
using api.models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<characters> characters= new List<characters> 
        {
            new characters(),
            new characters{ Id = 1, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<characters>> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<characters> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<characters>> AddCharacter(characters newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters); 
        } 
    }

}