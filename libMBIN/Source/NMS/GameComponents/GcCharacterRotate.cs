using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF350B567ECC52C73, NameHash = 0x1BC08C4BC1CAA288)]
    public class GcCharacterRotate : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Input;
        /* 0x10 */ public GcPrimaryAxis RotateAxis;
        /* 0x14 */ public float Damping;
        /* 0x18 */ public float RotateTime;
    }
}
