namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3B77A65A0F8428E, NameHash = 0xB5D67B6F)]
    public class GcMissionSequenceWaitForBuild : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 TargetTech;
    }
}
