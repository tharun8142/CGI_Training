using Microsoft.AspNetCore.Mvc;
using GoldServices.Entities;
using GoldServices.Repository;
using GoldServices.Services;

namespace GoldServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldController
    {
        IGoldService repo;
        public GoldController(IGoldService repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public IEnumerable<GoldOrnament> Get()
        {
            return this.repo.GetAll();
        }

        // GET api/<GoldController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GoldController>
        [HttpPost]
        public void Post([FromBody] GoldOrnament go)
        {
            this.repo.Add(go);
        }

        // PUT api/<GoldController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GoldOrnament go)
        {
            this.repo.Modify(id, go);
        }

        // DELETE api/<GoldController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this.repo.Remove(id);
        }

    }
}
