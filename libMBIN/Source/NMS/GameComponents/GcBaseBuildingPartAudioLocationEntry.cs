using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x919BCD22E78FFAC0, NameHash = 0xD7DAD354CC760BEE)]
    public class GcBaseBuildingPartAudioLocationEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PartId;
        /* 0x10 */ public GcBasePartAudioLocation AudioLocation;
    }
}
