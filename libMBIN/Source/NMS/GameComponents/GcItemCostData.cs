namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CFB944112E24A3A, NameHash = 0xA3976E1971095FC4)]
    public class GcItemCostData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 4)]
        /* 0x10 */ public float ChangePerSale;
        [NMS(Index = 1)]
        /* 0x14 */ public float Cost;
        [NMS(Index = 3)]
        /* 0x18 */ public float MaxCost;
        [NMS(Index = 2)]
        /* 0x1C */ public float MinCost;
    }
}
