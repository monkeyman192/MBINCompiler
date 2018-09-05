namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x130, Alignment = 0x8)]
    public class GcMissionSequenceBuild : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Part;
        /* 0x090 */ public GcBuildingPartSearchType Type;
        [NMS(Size = 0x80)]
        /* 0x0B0 */ public string DebugText;
    }
}
