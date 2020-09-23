using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoadTollAPI.Context;
using RoadTollAPI.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RoadTollAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        // GET: api/<OwnersController>
        [HttpGet]
        public IEnumerable<Owner> Get()
        {
            using(var context = new RoadTollAPIDBContext())
            {
                return context.Owners.Include(o => o.car).ToArray<Owner>();
            }
        }

        // GET api/<OwnersController>/5
        [HttpGet("{id}")]
        public Owner Get(int id)
        {
            using (var context = new RoadTollAPIDBContext())
            {
                var owner = context.Owners.Where(o => o.id == id).FirstOrDefault();
                if (owner != null)
                    return owner;
                else
                    return null;
            }
        }

        // POST api/<OwnersController>
        [HttpPost]
        public void Post([FromBody] Owner owner)
        {
            using (var context = new RoadTollAPIDBContext())
            {
                context.Owners.Add(owner);
                context.SaveChanges();
            }
        }


        // DELETE api/<OwnersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var context = new RoadTollAPIDBContext())
            {
                var owner = new Owner { id = id };
                context.Owners.Attach(owner);
                context.Owners.Remove(owner);
                context.SaveChanges();
            }
        }
    }
}
