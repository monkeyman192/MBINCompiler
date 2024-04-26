namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5E0C2C9BFB8D83D, NameHash = 0x639D09D542659F2F)]
    public class GcDebugShipTravelLine : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Dir;
        [NMS(Index = 0)]
        /* 0x10 */ public Vector3f Origin;
        [NMS(Index = 3)]
        /* 0x20 */ public float InfluenceRange;
        [NMS(Index = 2)]
        /* 0x24 */ public float Length;
    }
}
