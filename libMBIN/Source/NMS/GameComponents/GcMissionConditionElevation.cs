namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCFFE56D66B0CA, NameHash = 0x7952B1FC)]
    public class GcMissionConditionElevation : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float HeightAboveSea;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AllowInShip;
        [NMS(Index = 2)]
        /* 0x5 */ public bool TakeAmountFromSeasonData;
    }
}
