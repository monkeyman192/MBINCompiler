namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69D4C6F5C5341C1B, NameHash = 0x7E96F40C0051D69C)]
    public class GcCharacterMove : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Input;
        // size: 0x2
        public enum ModeEnum : uint {
            SetVelocity,
            ApplyForce,
        }
        [NMS(Index = 2)]
        /* 0x10 */ public ModeEnum Mode;
        [NMS(Index = 1)]
        /* 0x14 */ public float Strength;
    }
}
