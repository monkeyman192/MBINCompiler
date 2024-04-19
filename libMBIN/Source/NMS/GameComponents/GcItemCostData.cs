namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD34B7AB023B43319, NameHash = 0xA3976E1971095FC4)]
    public class GcItemCostData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float ChangePerSale;
        /* 0x14 */ public float Cost;
        /* 0x18 */ public float MaxCost;
        /* 0x1C */ public float MinCost;
    }
}
