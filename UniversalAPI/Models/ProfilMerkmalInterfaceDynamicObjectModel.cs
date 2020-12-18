using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalAPI
{
    public class ProfilMerkmalInterfaceDynamicObjectModel
    {
        public int ObjectID { get; set; }
        
        public string Bezeichnung { get; set; }

        public ProfilMerkmalInterfaceDynamicObjectModel(int ID, string bezeichnung)
        {
            ObjectID = ID;
            Bezeichnung = bezeichnung;
        }
    }
}
