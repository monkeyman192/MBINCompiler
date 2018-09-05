namespace libMBIN.Models.Structs
{
    public class GcInteractionBufferType : NMSTemplate
    {
        public int InterationBufferType;
        public string[] InterationBufferTypeValues()
        {
            return new[] { "Distress_Signal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature", "Maintenance", "Personal", "Personal_Maintenance"};
        }
    }
}
