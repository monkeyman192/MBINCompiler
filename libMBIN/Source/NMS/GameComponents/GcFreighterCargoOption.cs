namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2CB6B6081F8B9F08, NameHash = 0xAC8B5DD9)]
    public class GcFreighterCargoOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x10 */ public int MaxAmount;
        [NMS(Index = 1)]
        /* 0x14 */ public int MinAmount;
        [NMS(Index = 3)]
        /* 0x18 */ public int PercentChance;
    }
}
