using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalAPI.Models
{
    public class ProfiilMerkmalPack
    {
        public ProfiilMerkmalPack(ProfilMerkmalModel meta, bool delete = false)
        {
            Delete = delete;
            this.meta = meta;
        }

        public bool Delete { get; set; }
        public ProfilMerkmalModel meta { get; set; }
    }
}
