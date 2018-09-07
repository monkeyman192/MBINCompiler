namespace libMBIN.Models.Structs
{
    public class GcInventoryTechProbability : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Tech;
		public enum DesiredTechProbabilityEnum { Never, Rare, Common, Always }
		public DesiredTechProbabilityEnum DesiredTechProbability;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
