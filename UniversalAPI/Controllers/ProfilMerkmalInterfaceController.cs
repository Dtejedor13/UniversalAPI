using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [HttpGet]
        public List<ProfilMerkmalInterfaceDynamicObjectModel> Get()
        {
            List<ProfilMerkmalInterfaceDynamicObjectModel> returnList = new List<ProfilMerkmalInterfaceDynamicObjectModel>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.Delete == false)
                {
                    returnList.Add(new ProfilMerkmalInterfaceDynamicObjectModel(element.meta.ID, element.meta.Bez));        
                }
            }
            return returnList;
        }

        [HttpGet("{id}")]
        public string[] Get(int id)
        {
            List<string> returnedList = new List<string>();

            foreach (var element in DataBaseCsharp.ListofMerkmale)
            {
                if (element.meta.Parent == id && element.Delete == false)
                    returnedList.Add(element.meta.Bez);
            }

            return returnedList.ToArray();
        }
    }
}
