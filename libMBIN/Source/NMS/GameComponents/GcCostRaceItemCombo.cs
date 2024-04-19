using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE6D791CC453BB880, NameHash = 0x7FCC79CB46AA30F3)]
    public class GcCostRaceItemCombo : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public GcAlienRace AlienRace;
        /* 0x14 */ public int Amount;
    }
}
