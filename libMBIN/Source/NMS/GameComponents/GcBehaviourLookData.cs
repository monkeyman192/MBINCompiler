using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF530CA0023DD90CA, NameHash = 0x79CECC228E0EBC79)]
    public class GcBehaviourLookData : NMSTemplate
    {
        /* 0x00 */ public TkBlackboardDefaultValueBool CanLook;
        /* 0x18 */ public TkBlackboardDefaultValueBool FocusOnTarget;
        /* 0x30 */ public TkBlackboardDefaultValueBool RelaxedLook;
        /* 0x48 */ public NMSString0x10 LookTargetKey;
        /* 0x58 */ public bool LookWhenBeyondMaxAngle;
    }
}
