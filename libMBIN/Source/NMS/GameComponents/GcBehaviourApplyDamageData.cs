using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E37966820A9C48B, NameHash = 0x88EF02AAFC25BCE6)]
    public class GcBehaviourApplyDamageData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueId PlayerDamageType;
        /* 0x28 */ public TkBlackboardDefaultValueFloat Radius;
        /* 0x50 */ public TkBlackboardDefaultValueVector Offset;
    }
}
