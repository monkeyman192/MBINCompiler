using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37AADBDDEC55896D, NameHash = 0xEA25E33A)]
    public class GcSnapPointCondition : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 ObjectId;
        [NMS(Index = 3)]
        /* 0x10 */ public int SnapPointIndex;
        [NMS(Index = 1)]
        /* 0x14 */ public GcBaseSnapState SnapState;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x80 SnapPoint;
    }
}
