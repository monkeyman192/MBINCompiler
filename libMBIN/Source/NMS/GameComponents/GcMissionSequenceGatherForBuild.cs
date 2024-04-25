namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC5B34FA6047A48EA, NameHash = 0xB85371DB04FCCA0)]
    public class GcMissionSequenceGatherForBuild : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 GatherResource;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 TargetTech;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0xA0 */ public NMSString0x80 Message;
    }
}
