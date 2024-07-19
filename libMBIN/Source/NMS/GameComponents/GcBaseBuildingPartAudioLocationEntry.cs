using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC56C9F56B3721DC2, NameHash = 0x1C07402D)]
    public class GcBaseBuildingPartAudioLocationEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 PartId;
        [NMS(Index = 1)]
        /* 0x10 */ public GcBasePartAudioLocation AudioLocation;
    }
}
