using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF530CA0023DD90CA, NameHash = 0x79CECC228E0EBC79)]
    public class GcBehaviourLookData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public TkBlackboardDefaultValueBool CanLook;
        [NMS(Index = 2)]
        /* 0x18 */ public TkBlackboardDefaultValueBool FocusOnTarget;
        [NMS(Index = 3)]
        /* 0x30 */ public TkBlackboardDefaultValueBool RelaxedLook;
        [NMS(Index = 0)]
        /* 0x48 */ public NMSString0x10 LookTargetKey;
        [NMS(Index = 1)]
        /* 0x58 */ public bool LookWhenBeyondMaxAngle;
    }
}
