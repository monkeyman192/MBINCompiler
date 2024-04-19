namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69D4C6F5C5341C1B, NameHash = 0x7E96F40C0051D69C)]
    public class GcCharacterMove : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Input;
        // size: 0x2
        public enum ModeEnum : uint {
            SetVelocity,
            ApplyForce,
        }
        /* 0x10 */ public ModeEnum Mode;
        /* 0x14 */ public float Strength;
    }
}
