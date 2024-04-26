namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36FA8C6B3EBEF3F9, NameHash = 0xA93B3968B18A5750)]
    public class GcSettlementJudgementPerkOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Perk;
        [NMS(Index = 1)]
        /* 0x10 */ public float PerkChance;
    }
}
