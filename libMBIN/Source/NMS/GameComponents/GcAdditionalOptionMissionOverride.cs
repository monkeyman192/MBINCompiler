using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91872D162585807A, NameHash = 0x6A8BFA82)]
    public class GcAdditionalOptionMissionOverride : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public GcAlienPuzzleOption Option;
        [NMS(Index = 2)]
        /* 0x0F0 */ public List<int> ApplicableSeasons;
        [NMS(Index = 0)]
        /* 0x100 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x110 */ public bool MissionMustBeSelected;
    }
}
