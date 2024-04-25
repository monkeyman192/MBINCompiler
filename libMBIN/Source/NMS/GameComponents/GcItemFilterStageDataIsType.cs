using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x215AEE7FC10F3E75, NameHash = 0x8E5BBB7BCB8B358A)]
    public class GcItemFilterStageDataIsType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A DisabledMessage;
        [NMS(Index = 1)]
        /* 0x20 */ public GcInventoryType Type;
    }
}
