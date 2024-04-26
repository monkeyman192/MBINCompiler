using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6D791CC453BB880, NameHash = 0x7FCC79CB46AA30F3)]
    public class GcCostRaceItemCombo : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 2)]
        /* 0x10 */ public GcAlienRace AlienRace;
        [NMS(Index = 1)]
        /* 0x14 */ public int Amount;
    }
}
