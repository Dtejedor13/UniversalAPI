namespace UniversalAPI
{
    public class ProfilMerkmalInterfaceDynamicObjectModel
    {
        public int ObjectID { get; set; }

        public string Bezeichnung { get; set; }

        public bool isContainer {get; set;}
        public ProfilMerkmalInterfaceDynamicObjectModel(int ID, string bezeichnung, bool container)
        {
            ObjectID = ID;
            Bezeichnung = bezeichnung;
            isContainer = container;
        }
    }
}
