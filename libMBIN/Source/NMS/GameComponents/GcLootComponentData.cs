namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7173DCD61496ED, NameHash = 0x1E85F3A419864E16)]
    public class GcLootComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Reward;
        /* 0x10 */ public NMSString0x10 TimeOutEffect;
        /* 0x20 */ public Vector2f Timed;
        /* 0x28 */ public float FlashPercent;
        /* 0x2C */ public int NumFlashes;
        /* 0x30 */ public bool DeathPoint;
        /* 0x31 */ public bool KeepUpright;
        /* 0x32 */ public bool PhysicsControlled;
    }
}
