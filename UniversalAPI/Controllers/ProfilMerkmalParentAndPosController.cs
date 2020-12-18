using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversalAPI.Controllers
{
    [Route("api/parent")]
    [ApiController]
    public class ProfilMerkmalParentAndPosController : ControllerBase
    {
        // GET: api/<ProfilMerkmalParentAndPosController>
        [HttpGet]
        public List<string> Get()
        {
            return null;
        }

        // GET api/<ProfilMerkmalParentAndPosController>/5
        [HttpGet("{id}")]
        public string[] Get(int id)
        {
            List<string> returnedList = new List<string>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Parent == id)
                    returnedList.Add(element.Bez);
            }

            return returnedList.ToArray();
        }

        // POST api/<ProfilMerkmalParentAndPosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProfilMerkmalParentAndPosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfilMerkmalParentAndPosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
