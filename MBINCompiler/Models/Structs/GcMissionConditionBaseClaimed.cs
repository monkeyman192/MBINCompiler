namespace MBINCompiler.Models.Structs
{
    public class GcMissionConditionBaseClaimed : NMSTemplate
    {
        /* 0x00 */ public bool Claimed;
        /* 0x04 */ public GcPersistentBaseTypes Base;
        public int IsOnCurrentSystem;
        public string[] IsOnCurrentSystemValues()
        {
            return new[] { "DontCare", "Yes", "No" };
        }
    }
}
