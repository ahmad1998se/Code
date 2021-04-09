using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    /// <summary>
    /// This is the controller who manage Api
   
    /// </summary>
    public class PeopleController : ApiController
    {


        private List<Person> people = new List<Person>();

        public PeopleController()
        {

            people.Add(new Person { FirstName = "Ahmad", LastName = "Almahameed", Id = 1 });
            people.Add(new Person { FirstName = "Eman", LastName = "Almahameed", Id = 2 });
            people.Add(new Person { FirstName = "Anas", LastName = "Almahameed", Id = 3 });


        }
        /// <summary>
        /// Here Can Return all The names that Stored
        /// </summary>
        /// <returns>String List of First Names</returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {

            List<string> output = new List<string>();

            foreach (var x in people)
            {
                output.Add(x.FirstName);
            }

            return output;
        }





        // GET: api/People
        public List<Person> Get()
        {

            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            //return people.Where(x=>x.Id==id).FirstOrDefault();
            return people.SingleOrDefault(x => x.Id == id);

        }

        // POST: api/People
        public void Post(Person obj)
        {

            people.Add(obj);
        }

        // PUT: api/People/5    
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}
