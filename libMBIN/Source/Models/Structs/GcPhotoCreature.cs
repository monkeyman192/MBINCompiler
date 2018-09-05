namespace libMBIN.Models.Structs
{
    public class GcPhotoCreature : NMSTemplate
    {
        public int PhotoCreatureType;
        public string[] PhotoCreatureTypeValues()
        {
            return new[] { "Ground", "Water", "Air"};
        }
    }
}
