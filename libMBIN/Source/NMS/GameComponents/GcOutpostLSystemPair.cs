using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97FF5B3ACAE1CDF1, NameHash = 0x3C7F32FAD34D5752)]
    public class GcOutpostLSystemPair : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public NMSString0x80[] LSystems;
        [NMS(Index = 0)]
        /* 0x480 */ public NMSString0x20 Locator;
    }
}
