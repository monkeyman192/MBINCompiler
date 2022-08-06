using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A39E7A9B4387E46, NameHash = 0x7E96F40C0051D69C)]
    public class GcCharacterMove : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Input;
        /* 0x10 */ public float Strength;
        public enum ModeEnum { SetVelocity, ApplyForce }
        /* 0x14 */ public ModeEnum Mode;
    }
}
