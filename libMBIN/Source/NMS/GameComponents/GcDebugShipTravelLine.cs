namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5E0C2C9BFB8D83D, NameHash = 0x639D09D542659F2F)]
    public class GcDebugShipTravelLine : NMSTemplate
    {
        /* 0x00 */ public Vector3f Dir;
        /* 0x10 */ public Vector3f Origin;
        /* 0x20 */ public float InfluenceRange;
        /* 0x24 */ public float Length;
    }
}
