namespace libMBIN.Models.Structs
{
    public class GcPhotoPlant : NMSTemplate
    {
        public int PhotoPlantType;
        public string[] PhotoPlantTypeValues()
        {
            return new[] { "Zinc", "Thamium", "Platinum"};
        }
    }
}
