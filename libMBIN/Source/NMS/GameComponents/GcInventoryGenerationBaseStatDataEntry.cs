namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2C3DFA47C10D607, NameHash = 0xBE33B4E320477672)]
    public class GcInventoryGenerationBaseStatDataEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 BaseStatID;
        [NMS(Index = 2)]
        /* 0x10 */ public float Max;
        [NMS(Index = 4)]
        /* 0x14 */ public float MaxFixedAdd;
        [NMS(Index = 1)]
        /* 0x18 */ public float Min;
        [NMS(Index = 3)]
        /* 0x1C */ public float MinFixedAdd;
    }
}
