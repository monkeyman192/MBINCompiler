namespace libMBIN.Models.Structs
{
    public class GcRewardShipAssistance : NMSTemplate
    {
		public enum AssistanceTypeEnum { Police, Wingmen }
		public AssistanceTypeEnum AssistanceType;

        public float Time;
    }
}
