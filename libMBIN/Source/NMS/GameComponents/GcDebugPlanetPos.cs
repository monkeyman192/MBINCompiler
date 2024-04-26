namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87445091AC91B41D, NameHash = 0x670C19192705F25A)]
    public class GcDebugPlanetPos : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Position;
        [NMS(Index = 1)]
        /* 0x10 */ public bool OverridePosition;
    }
}
