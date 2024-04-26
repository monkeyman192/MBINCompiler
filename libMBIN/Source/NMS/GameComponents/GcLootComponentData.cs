namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7173DCD61496ED, NameHash = 0x1E85F3A419864E16)]
    public class GcLootComponentData : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public NMSString0x10 Reward;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 TimeOutEffect;
        [NMS(Index = 0)]
        /* 0x20 */ public Vector2f Timed;
        [NMS(Index = 3)]
        /* 0x28 */ public float FlashPercent;
        [NMS(Index = 4)]
        /* 0x2C */ public int NumFlashes;
        [NMS(Index = 2)]
        /* 0x30 */ public bool DeathPoint;
        [NMS(Index = 6)]
        /* 0x31 */ public bool KeepUpright;
        [NMS(Index = 5)]
        /* 0x32 */ public bool PhysicsControlled;
    }
}
