using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x327397905C5F9488, NameHash = 0x6A8BFA82)]
    public class GcAdditionalOptionMissionOverride : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcAlienPuzzleOption Option;
        [NMS(Index = 2)]
        /* 0x0F8 */ public List<int> ApplicableSeasons;
        [NMS(Index = 0)]
        /* 0x108 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x118 */ public bool MissionMustBeSelected;
    }
}
