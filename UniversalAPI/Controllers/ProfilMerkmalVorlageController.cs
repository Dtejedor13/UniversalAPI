using EFDataAccessCore.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UniversalAPI.Controllers
{
    /// <summary>
    /// return empty Profilmerkmal Object as sample or Mockup To Create a new Object
    /// </summary>
    [Route("api/pm-vorlage")]
    [ApiController]
    public class ProfilMerkmalVorlageController : ControllerBase
    {
        [HttpGet]
        public ProfilMerkmalModel Get()
        {
            ProfilMerkmalModel pm = new ProfilMerkmalModel();
            return pm;
        }
    }
}
