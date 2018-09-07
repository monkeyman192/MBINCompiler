namespace libMBIN.Models.Structs
{
    public class GcInteractionBufferType : NMSTemplate
    {
		public enum InterationBufferTypeEnum { Distress_Signal, Crate, Destructable, Terrain, Cost, Building, Creature, Maintenance, Personal, Personal_Maintenance }
		public InterationBufferTypeEnum InterationBufferType;
    }
}
