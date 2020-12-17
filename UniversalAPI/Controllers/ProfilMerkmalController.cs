using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversalAPI.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    [Route("api/pm")]
    [ApiController]
    public class ProfilMerkmalController : ControllerBase
    {
        List<ProfilMerkmalModel> DBClone = DataBaseCsharp.ListofMerkmale; // get Copy from Database

        // GET: api/pm
        [HttpGet]
        public List<ProfilMerkmalModel> Get()
        {
            return DBClone;
        }

        // GET api/pm5
        [HttpGet("{id}")]
        public ProfilMerkmalModel Get(int id)
        {
            return DBClone.Where(x => x.ID == id).FirstOrDefault();
        }

        // POST api/<ProfilMerkmalController>
        [HttpPost]
        public void Post(ProfilMerkmalModel value)
        {
            DBClone.Add(value);
        }

        // PUT api/<ProfilMerkmalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProfilMerkmalModel value)
        {
            for (int i = 0; i < DBClone.Count; i++)
            {
                if (id == DBClone[i].ID)
                {
                    DBClone[i] = value;
                    break;
                }
            }
        }

        // DELETE api/<ProfilMerkmalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var itemToRemove = DBClone.Single(r => r.ID == id);
            DBClone.Remove(itemToRemove);
        }
    }
}
