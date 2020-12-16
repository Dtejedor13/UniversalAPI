using UniversalAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversalAPI
{
    public static class DataBaseCsharp
    {
        public static List<ProfilMerkmalModel> ListofMerkmale = new List<ProfilMerkmalModel>()
        {
            new ProfilMerkmalModel { ID = 26, Parent = 24, Pos = 2, Typ = 1, Bez = "Alter", BezWeb = "", Info= "", WichtigMöglich= true, WichtigInfo = null, Zusammenführen = false, DuplizierenMöglich = true}
        };
    }
}