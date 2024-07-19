using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97FF5B3ACAE1CDF1, NameHash = 0xDF299888)]
    public class GcOutpostLSystemPair : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x00 */ public VariableSizeString[] LSystems;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x20 Locator;
    }
}
