namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x634DDDD942EBE5BA, NameHash = 0xE01E234D)]
    public class GcMissionSequenceGatherForBuild : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 GatherResource;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x30 */ public NMSString0x10 TargetTech;
    }
}
