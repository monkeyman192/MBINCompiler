namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceStartScanEvent : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        /* 0x080 */ public float Time;
        [NMS(Size = 0x10)]
        /* 0x084 */ public string Event;
        /* 0x098 */ public bool FromShipScan;
        public int Table;
        /* 0x09C */ public string[] TableValues()
        {
            return new[] { "Space", "Planet", "Mission", "Tutorial" };
        }
    }
}
