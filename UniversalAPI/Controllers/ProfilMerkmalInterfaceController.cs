using System.Collections.Generic;
using EFDataAccessCore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversalAPI.Controllers
{
    /// <summary>
    /// Get ProfilMerkmal Object Interface, (name of Object):string, (ID of Object):Int
    /// </summary>
    [Route("api/pmif")]
    [ApiController]
    public class ProfilMerkmalInterfaceController : ControllerBase
    {
        private bool CheckifContainer(int ID)
        {
            List<ProfilMerkmalModel> returnlist = new List<ProfilMerkmalModel>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Delete == false && element.Meta.Parent == ID)
                {
                    returnlist.Add(element.Meta);
                }
            }

            if (returnlist.Count > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Return Profil Merkmal Interface
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<ProfilMerkmalInterfaceDynamicObjectModel> Get()
        {
            List<ProfilMerkmalInterfaceDynamicObjectModel> returnList = new List<ProfilMerkmalInterfaceDynamicObjectModel>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Delete == false)
                {
                    returnList.Add(new ProfilMerkmalInterfaceDynamicObjectModel(element.Meta.ID, element.Meta.Bez, CheckifContainer(element.Meta.ID)));        
                }
            }
            return returnList;
        }

        /// <summary>
        /// Returns ProfilMerkmal Interface by ParentID
        /// </summary>
        /// <param name="ParentID"></param>
        /// <returns></returns>
        [Route("parent/{ParentID}")]
        [HttpGet]
        public List<ProfilMerkmalInterfaceDynamicObjectModel> GetbyParent(int ParentID)
        {
            List<ProfilMerkmalInterfaceDynamicObjectModel> returnList = new List<ProfilMerkmalInterfaceDynamicObjectModel>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Delete == false && element.Meta.Parent == ParentID)
                {
                    returnList.Add(new ProfilMerkmalInterfaceDynamicObjectModel(element.Meta.ID, element.Meta.Bez, CheckifContainer(element.Meta.ID)));
                }
            }
            return returnList;
        }

        /// <summary>
        /// Return Profil Merkmal interface by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string[] Get(int id)
        {
            List<string> returnedList = new List<string>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Meta.Parent == id && element.Delete == false)
                    returnedList.Add(element.Meta.Bez);
            }

            return returnedList.ToArray();
        }
    }
}
