using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demoapi.Models;

namespace demoapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<person> Get()
        {
            List<person> persons = new List<person>();
            persons.Add(new person
            {
                Id = 1,
                Name = "One",
                age = 11
            });

            persons.Add(new person
            {
                Id = 2,
                Name = "two",
                age = 12
            });

            return persons;
        }



        [HttpGet("{id}")]
        public person Get(int id)
        {

            return new person
            {
                Id = id,
                Name = "Ake",
                age = 37
            };
        }
        [HttpDelete("{id}")]
        public person Del(int id)
        {

            return new person
            {
                Id = id,
                Name = "Deleted",
                age = 37
            };
        }

        [HttpPost]
        public person Create(person data)
        {
            data.Name += "Created_";
            return data;
        }
        [HttpPut]
        public person update(person data)
        {
            data.Name += "updated_";
            return data;
        }
    }
}
