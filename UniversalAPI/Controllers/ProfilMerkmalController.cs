using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversalAPI.Controllers
{
    [Route("api/pm")]
    [ApiController]
    public class ProfilMerkmalController : ControllerBase
    {
        /// <summary>
        /// Get All Items 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProfilMerkmalModel> Get()
        {
            return DataBaseCsharp.ListofMerkmale.ToList();
        }

        /// <summary>
        /// Get One Item by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ProfilMerkmalModel Get(int id)
        {
            return DataBaseCsharp.ListofMerkmale.Where(x => x.ID == id).FirstOrDefault();
        }

        /// <summary>
        /// Insert new Profilmerkmal
        /// </summary>
        /// <param name="value">Object ProfilmerkmalModel</param>
        [HttpPut]
        public void Put(ProfilMerkmalModel value)
        {
            DataBaseCsharp.ListofMerkmale.Add(value);
        }

        /// <summary>
        /// Update Profilmerkmal 
        /// </summary>
        /// <param name="value">Object ProfilmerkmalModel</param>
        /// <returns></returns>
        [HttpPost()]
        public HttpResponseMessage Post([FromBody] ProfilMerkmalModel value)
        {
            var updatedItem = DataBaseCsharp.ListofMerkmale.FirstOrDefault(x => x.ID == value.ID);

            if (updatedItem != null)
            {
                updatedItem.Info = value.Info;
                updatedItem.KategorieId = value.KategorieId;
                updatedItem.Parent = value.Parent;
                updatedItem.Pos = value.Pos;
                updatedItem.Typ = value.Typ;
                updatedItem.WichtigInfo = value.WichtigInfo;
                updatedItem.WichtigMöglich = value.WichtigMöglich;
                updatedItem.Zusammenführen = value.Zusammenführen;
                updatedItem.Bez = value.Bez;
                updatedItem.BezWeb = value.BezWeb;
            }
            else
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Delete Item by ID
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete()]
        public HttpResponseMessage Delete(int id)
        {
            var updatedItem = DataBaseCsharp.ListofMerkmale.FirstOrDefault(x => x.ID == id);


            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
