namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71FEDA0627F8F681, NameHash = 0x132E24BDAE218C83)]
    public class GcLegacyItem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 ConvertID;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x20 */ public float ConvertRatio;
        [NMS(Index = 3)]
        /* 0x24 */ public bool AddNewRecipe;
        [NMS(Index = 4)]
        /* 0x25 */ public bool RemoveOldRecipe;
    }
}
