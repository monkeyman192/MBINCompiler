using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA89D368437294ACE, NameHash = 0x5A0F4731)]
    public class GcSwarmResource : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public TkModelResource Model;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x30 */ public float MoveAnimSpeedMax;
        [NMS(Index = 2)]
        /* 0x34 */ public float MoveAnimSpeedMin;
        [NMS(Index = 1)]
        /* 0x38 */ public float Scale;
        [NMS(Index = 5)]
        /* 0x3C */ public bool ReverseForward;
        [NMS(Index = 6)]
        /* 0x3D */ public bool UsePhysics;
    }
}
