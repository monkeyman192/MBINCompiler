using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CB3EEDF29D9A306, NameHash = 0x223C08FAB30D9754)]
    public class GcWonderRecordCustomData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcWonderType ActualType;
        [NMS(Index = 0)]
        /* 0x4 */ public NMSString0x40 CustomName;
    }
}
