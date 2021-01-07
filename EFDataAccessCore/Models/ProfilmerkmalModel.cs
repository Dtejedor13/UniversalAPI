using System;

namespace EFDataAccessCore.Models
{
    public class ProfilMerkmalModel : IDisposable
    {
        public int ID { get; set; } = 0;
        public int Parent { get; set; } = 0;
        public int KategorieId { get; set; } = 0;
        public string Bez { get; set; } = "";
        public string BezWeb { get; set; } = "";
        public string Info { get; set; } = "";
        public int Typ { get; set; } = 0;
        public string WichtigInfo { get; set; } = "";
        public bool WichtigMöglich { get; set; } = false;
        public bool DuplizierenMöglich { get; set; } = false;
        public bool Zusammenführen { get; set; } = false;
        public int Pos { get; set; } = 0;

        public void Dispose()
        {
            
        }
    }
}