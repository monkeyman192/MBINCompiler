namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE12C5927A18E252D, NameHash = 0x2128EDF6E38E9344)]
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
