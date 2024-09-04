namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8990DDE44B133963, NameHash = 0x2FDB2B23)]
    public class GcFishSizeProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int BaseWeight;
        [NMS(Index = 3)]
        /* 0x4 */ public int DepthModifier;
        [NMS(Index = 2)]
        /* 0x8 */ public int DepthRangeMax;
        [NMS(Index = 1)]
        /* 0xC */ public int DepthRangeMin;
    }
}
