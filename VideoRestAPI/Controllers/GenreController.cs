using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoMenuBLL;
using VideoMenuBLL.BusiessObjects;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoRestAPI.Controllers
{
    [Route("api/[controller]")]
    public class GenreController : Controller
    {
        BLLFacade facade = new BLLFacade();
        // GET: api/values
        [HttpGet]
        public IEnumerable<GenreBO> Get()
        {
            return facade.GenreService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public GenreBO Get(int id)
        {
            return facade.GenreService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]GenreBO genre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(facade.GenreService.Create(genre));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]GenreBO genre)
        {
            if (id != genre.Id)
            {
                return StatusCode(405, "Path Id does not match video ID in json object");
            }
            try
            {

                return Ok(facade.GenreService.Update(genre));
            }
            catch (InvalidOperationException e)
            {
                return StatusCode(404, e.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            facade.GenreService.Delete(id);
        }
    }
}
