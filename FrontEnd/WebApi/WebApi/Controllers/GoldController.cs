using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Entities;
using WebApi.Controllers.Repository;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldController : ControllerBase
    {
        private IGoldRepository repository;
        public GoldController(IGoldRepository repo)
        {
            repository = repo;
        }
        // GET: api/<GoldController>
        [HttpGet]
        public IEnumerable<GoldOrnament> Get()
        {
            return repository.display();
        }

        // GET api/<GoldController>/5
        [HttpGet("{id}")]
        public GoldOrnament Get(int id)
        {
            return repository.GetById(id);
        }

        // POST api/<GoldController>
        [HttpPost]
        public void Post([FromBody] GoldOrnament go)
        {
            repository.Add(go);
        }

        // PUT api/<GoldController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] GoldOrnament newdata)
        {
            if (repository.update(id, newdata))
                return new OkObjectResult("success");
            return new NoContentResult();
          
        }

        // DELETE api/<GoldController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
        }
        [HttpGet]
        [Route("price/{price:double}")]//attribute based routing
        public IEnumerable<GoldOrnament> Get(double price)
        {
            return new List<GoldOrnament>() { new GoldOrnament() { Rate=price } };
        }
    }
}
