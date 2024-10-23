using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7838A6FC478D8C1, NameHash = 0x31D36259)]
    public class GcCustomisationHeadToRace : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A HeadDescriptor;
        [NMS(Index = 2)]
        /* 0x20 */ public GcAlienRace HeadAnimationRace;
        [NMS(Index = 1)]
        /* 0x24 */ public GcAlienRace Race;
    }
}
