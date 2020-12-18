using System;

namespace UniversalAPI
{
    public class ProfilMerkmalModel : IDisposable
    {
        public int ID { get; set; }
        public int Parent { get; set; }
        public int KategorieId { get; set; }
        public string Bez { get; set; }
        public string BezWeb { get; set; }
        public string Info { get; set; }
        public int Typ { get; set; }
        public string WichtigInfo { get; set; }
        public bool WichtigMöglich { get; set; }
        public bool DuplizierenMöglich { get; set; }
        public bool Zusammenführen { get; set; }
        public int Pos { get; set; }

        public void Dispose()
        {
            
        }
    }
}