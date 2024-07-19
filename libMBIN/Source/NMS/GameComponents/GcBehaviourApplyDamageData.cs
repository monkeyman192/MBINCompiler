using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E2FC991867A06EA, NameHash = 0x8BE0E99B)]
    public class GcBehaviourApplyDamageData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkBlackboardDefaultValueVector Offset;
        [NMS(Index = 0)]
        /* 0x30 */ public TkBlackboardDefaultValueId PlayerDamageType;
        [NMS(Index = 1)]
        /* 0x58 */ public TkBlackboardDefaultValueFloat Radius;
    }
}
