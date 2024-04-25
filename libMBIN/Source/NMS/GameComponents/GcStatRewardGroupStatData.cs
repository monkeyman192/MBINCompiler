namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC63B8E79C3EAC63A, NameHash = 0x2614BBB7F640C2D5)]
    public class GcStatRewardGroupStatData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 StatID;
        [NMS(Index = 2)]
        /* 0x10 */ public float ManualAdjust;
        [NMS(Index = 1)]
        /* 0x14 */ public float StatMultiplier;
    }
}
