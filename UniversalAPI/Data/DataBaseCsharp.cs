using UniversalAPI.Models;
using System.Collections.Concurrent;
using EFDataAccessCore.Models;
using EFDataAccessCore;

namespace UniversalAPI
{
    public static class DataBaseCsharp
    {
        public static void LoadDatafromDB()
        {
            using (ProfilMerkmalSqlController sqlDB = new ProfilMerkmalSqlController())
            {
                foreach (ProfilMerkmalModel element in sqlDB.DBset)
                {
                    ListofMerkmale.Add(new ProfiilMerkmalPack(new ProfilMerkmalModel{
                            ID = element.ID,
                            Parent = element.Parent,
                            Pos = element.Pos,
                            Typ = element.Typ,
                            Bez = element.Bez,
                            BezWeb = element.BezWeb,
                            Info = element.Info,
                            WichtigMöglich = element.WichtigMöglich,
                            WichtigInfo = element.WichtigInfo,
                            Zusammenführen = element.Zusammenführen,
                            DuplizierenMöglich = element.DuplizierenMöglich
                        }));
                }
            }
        }

        public static ConcurrentBag<ProfiilMerkmalPack> ListofMerkmale = new ConcurrentBag<ProfiilMerkmalPack>();
        #region static data
        //{
        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 6, 
        //        Parent = 0, 
        //        Pos = 1, 
        //        Typ = 1, 
        //        Bez = "Personenprofilmerkmale", 
        //        BezWeb = null, 
        //        Info = null, 
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 16, 
        //        Parent = 0, 
        //        Pos = 2, 
        //        Typ = 1, 
        //        Bez = "Adressenprofilmerkmale", 
        //        BezWeb = null, 
        //        Info = null, 
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false,
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 18, 
        //        Parent = 0, 
        //        Pos = 3, 
        //        Typ = 1, 
        //        Bez = "Job/Miete-Merkmale", 
        //        BezWeb = null, 
        //        Info = null, 
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 22, 
        //        Parent = 6, 
        //        Pos = 6, 
        //        Typ = 1, 
        //        Bez = "Bilder/Video/... (Wie?)", 
        //        BezWeb = null, 
        //        Info = null, 
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 23, 
        //        Parent = 22, 
        //        Pos = 1, 
        //        Typ = 1, 
        //        Bez = "Identifikation", 
        //        BezWeb = null, 
        //        Info = "Ist das Gesicht zu erkennen? Erscheint nicht auf Ladies.de",
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 24, 
        //        Parent = 6, 
        //        Pos = 1, 
        //        Typ = 1, 
        //        Bez = "Merkmale (Wer?)", 
        //        BezWeb = null, 
        //        Info = null, 
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 25, 
        //        Parent = 24, 
        //        Pos = 2, 
        //        Typ = 2, 
        //        Bez = "Alter",
        //        BezWeb = null, 
        //        Info = null,
        //        WichtigMöglich = true,
        //        WichtigInfo = null,
        //        Zusammenführen = false,
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 26,
        //        Parent = 25,
        //        Pos = 3, 
        //        Typ = 15,
        //        Bez = "Alter",
        //        BezWeb = "", 
        //        Info= "Bitte Alter auswählen! ", 
        //        WichtigMöglich= true,
        //        WichtigInfo = null,
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 27, 
        //        Parent = 35, 
        //        Pos = 1, 
        //        Typ = 10, 
        //        Bez = "weiblich", 
        //        BezWeb = "weibl.", 
        //        Info = null, 
        //        WichtigMöglich = true, 
        //        WichtigInfo = null,
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 28,
        //        Parent = 35, 
        //        Pos = 2, 
        //        Typ = 10,
        //        Bez = "männlich - Gay", 
        //        BezWeb = "männl.",
        //        Info = "Der Mann bietet seine Dienste Männern an.",
        //        WichtigMöglich = true, 
        //        WichtigInfo = null,
        //        Zusammenführen = false,
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 29, 
        //        Parent = 35, 
        //        Pos = 3, 
        //        Typ = 10, 
        //        Bez = "männlich - Dressman",
        //        BezWeb = "männl.",
        //        Info = "Der Mann bietet seine Dienste Frauen an.",
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 30, Parent = 35, Pos = 4, Typ = 10, Bez = "Transsexuell (TS)", BezWeb = "TS", Info = null, WichtigMöglich = true, WichtigInfo = null, Zusammenführen = false, DuplizierenMöglich = true }),


        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 32, 
        //        Parent = 24, 
        //        Pos = 25, 
        //        Typ = 1, 
        //        Bez = "Herkunft", 
        //        BezWeb = null, 
        //        Info = null,
        //        WichtigMöglich = true, 
        //        WichtigInfo = null,
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    }),

        //    new ProfiilMerkmalPack(
        //    new ProfilMerkmalModel { 
        //        ID = 33,
        //        Parent = 24, 
        //        Pos = 26, 
        //        Typ = 1, 
        //        Bez = "Haare", 
        //        BezWeb = null, 
        //        Info = null, 
        //        WichtigMöglich = true, 
        //        WichtigInfo = null, 
        //        Zusammenführen = false, 
        //        DuplizierenMöglich = true 
        //    })
        //};
        #endregion
    }
}