using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF59BD607E75A9055, NameHash = 0xD7DAD354CC760BEE)]
    public class GcBaseBuildingPartAudioLocationEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 PartId;
        [NMS(Index = 1)]
        /* 0x10 */ public GcBasePartAudioLocation AudioLocation;
    }
}
