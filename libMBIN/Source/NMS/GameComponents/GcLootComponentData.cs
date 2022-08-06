using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE828A30AA74AE1FD, NameHash = 0x1E85F3A419864E16)]
    public class GcLootComponentData : NMSTemplate
    {
        /* 0x00 */ public Vector2f Timed;
        /* 0x08 */ public NMSString0x10 TimeOutEffect;
        /* 0x18 */ public bool DeathPoint;
        /* 0x1C */ public float FlashPercent;
        /* 0x20 */ public int NumFlashes;
        /* 0x24 */ public bool PhysicsControlled;
        /* 0x25 */ public bool KeepUpright;
        /* 0x28 */ public NMSString0x10 Reward;
    }
}
