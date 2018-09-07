namespace libMBIN.Models.Structs
{
    public class GcMissionConditionBaseClaimed : NMSTemplate
    {
        /* 0x00 */ public bool Claimed;
        /* 0x04 */ public GcPersistentBaseTypes Base;
		public enum IsOnCurrentSystemEnum { DontCare, Yes, No }
		public IsOnCurrentSystemEnum IsOnCurrentSystem;
    }
}
