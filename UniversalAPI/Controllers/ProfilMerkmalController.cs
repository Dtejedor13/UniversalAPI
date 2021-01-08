using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using EFDataAccessCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace UniversalAPI.Controllers
{
    [Route("api/pm")]
    [ApiController]
    public class ProfilMerkmalController : ControllerBase
    {
        /// <summary>
        /// Get All ProfilMerkmal Objects 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProfilMerkmalModel> Get()
        {
            List<ProfilMerkmalModel> returnlist = new List<ProfilMerkmalModel>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Delete == false)
                {
                    returnlist.Add(element.Meta);
                }
            }

            return returnlist;
        }

        /// <summary>
        /// Get One ProfilMerkmal Object by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ProfilMerkmalModel Get(int id)
        {
            var returnobj = DataBaseCsharp.ListofMerkmale.Where(x => x.Meta.ID == id).FirstOrDefault();

            if (returnobj != null)
            {
                if (returnobj.Delete == false)
                    return returnobj.Meta;
                else
                    return null;
            }
            else
                return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ParentID">ID of ProfilMerkmal</param>
        /// <returns></returns>
        [HttpGet]
        [Route("parent/{ParentID}")]
        public List<ProfilMerkmalModel> GetbyParent(int ParentID)
        {
            List<ProfilMerkmalModel> returnlist = new List<ProfilMerkmalModel>();
            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Delete == false && element.Meta.Parent == ParentID)
                {
                    returnlist.Add(element.Meta);
                }
            }

            return returnlist;
        }

        /// <summary>
        /// Insert new Profilmerkmal Object
        /// </summary>
        /// <param name="value">Object ProfilmerkmalModel</param>
        [HttpPut]
        public HttpResponseMessage Put([FromBody] ProfilMerkmalModel value)
        {
            var existingItem = DataBaseCsharp.ListofMerkmale.FirstOrDefault(x => x.Meta.ID == value.ID);

            if (existingItem == null || existingItem.Delete == true)
            {
                DataBaseCsharp.ListofMerkmale.Add(new Models.ProfiilMerkmalPack(value, false));
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
                return new HttpResponseMessage(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// Update Profilmerkmal Object
        /// </summary>
        /// <param name="value">Object ProfilmerkmalModel</param>
        /// <returns></returns>
        [HttpPost()]
        public HttpResponseMessage Post([FromBody] ProfilMerkmalModel value)
        {
            var updatedItem = DataBaseCsharp.ListofMerkmale.FirstOrDefault(x => x.Meta.ID == value.ID && x.Delete == false);

            if (updatedItem != null)
            {
                updatedItem.Meta.Info = value.Info;
                updatedItem.Meta.KategorieId = value.KategorieId;
                updatedItem.Meta.Parent = value.Parent;
                updatedItem.Meta.Pos = value.Pos;
                updatedItem.Meta.Typ = value.Typ;
                updatedItem.Meta.WichtigInfo = value.WichtigInfo;
                updatedItem.Meta.DuplizierenMöglich = value.DuplizierenMöglich;
                updatedItem.Meta.Zusammenführen = value.Zusammenführen;
                updatedItem.Meta.Bez = value.Bez;
                updatedItem.Meta.BezWeb = value.BezWeb;
            }
            else
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        /// <summary>
        /// Delete ProfilMerkmal Object
        /// <param name="id">ID of the ProfilmerkmalModel Object to delete</param>
        /// </summary>
        [HttpDelete("{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var itemToDelete = DataBaseCsharp.ListofMerkmale.FirstOrDefault(x => x.Meta.ID == id);

            if (itemToDelete != null && itemToDelete.Delete == false)
            {
                itemToDelete.Delete = true;
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
