namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D82F8C85D74329B, NameHash = 0x2128EDF6E38E9344)]
    public class GcLandingHelperComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float ActiveDistanceMax;
        [NMS(Index = 0)]
        /* 0x4 */ public float ActiveDistanceMin;
        [NMS(Index = 2)]
        /* 0x8 */ public bool LandPoint;
    }
}
