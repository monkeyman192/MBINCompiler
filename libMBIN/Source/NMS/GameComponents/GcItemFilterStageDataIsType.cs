using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E88B21AA56938BB, NameHash = 0x52E946AD)]
    public class GcItemFilterStageDataIsType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A DisabledMessage;
        [NMS(Index = 1)]
        /* 0x20 */ public GcInventoryType Type;
    }
}
