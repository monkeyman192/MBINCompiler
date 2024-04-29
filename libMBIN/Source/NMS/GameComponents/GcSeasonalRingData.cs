namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F90E216CB55A3B1, NameHash = 0x772BC47975467C69)]
    public class GcSeasonalRingData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float CoreOpacity;
        [NMS(Index = 1)]
        /* 0x4 */ public float RingOpacity;
        [NMS(Index = 0)]
        /* 0x8 */ public float RingSize;
    }
}
