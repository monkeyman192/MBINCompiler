using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB185E9E89F4E3649, NameHash = 0x88EF02AAFC25BCE6)]
    public class GcBehaviourApplyDamageData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueVector Offset;
        /* 0x30 */ public TkBlackboardDefaultValueId PlayerDamageType;
        /* 0x58 */ public TkBlackboardDefaultValueFloat Radius;
    }
}
