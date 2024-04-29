namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78944A6E94DE7B51, NameHash = 0x748F2F6EDE9F5F18)]
    public class GcBuildingOverrideData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 0)]
        /* 0x10 */ public GcSeed Seed;
        [NMS(Index = 2)]
        /* 0x20 */ public int Index;
    }
}
