namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38EE3AC5336946AB, NameHash = 0x5384022399CAF09)]
    public class GcPerformanceFlyby : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float Length;
        [NMS(Index = 3)]
        /* 0x04 */ public float LockOffset;
        [NMS(Index = 5)]
        /* 0x08 */ public float LockSpeed;
        [NMS(Index = 4)]
        /* 0x0C */ public float LockTime;
        [NMS(Index = 1)]
        /* 0x10 */ public float Offset;
        [NMS(Index = 2)]
        /* 0x14 */ public bool Locked;
    }
}
