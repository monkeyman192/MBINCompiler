namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3BB8C227063A312, NameHash = 0x9C74A74AB0211EF6)]
    public class GcDoShipFlybyClose : NMSTemplate
    {
        /* 0x0 */ public float LockOffset;
        /* 0x4 */ public float LockSpread;
        /* 0x8 */ public float LockTime;
        /* 0xC */ public bool HailingBehaviour;
        /* 0xD */ public bool StayCloseAtLowSpeed;
    }
}
