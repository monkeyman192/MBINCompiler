namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9540F9F46EDC3C9F, NameHash = 0xAEE2DF0976A04EB1)]
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
