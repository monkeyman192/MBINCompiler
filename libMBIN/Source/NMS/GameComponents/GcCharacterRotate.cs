using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x681AD0B240E886DF, NameHash = 0xA3DE4371)]
    public class GcCharacterRotate : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Input;
        [NMS(Index = 2)]
        /* 0x10 */ public float Damping;
        [NMS(Index = 1)]
        /* 0x14 */ public GcPrimaryAxis RotateAxis;
        [NMS(Index = 3)]
        /* 0x18 */ public float RotateTime;
    }
}
