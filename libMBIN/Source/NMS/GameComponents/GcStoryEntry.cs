using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x57FD0DF48DC10CD9, NameHash = 0xB359A426)]
    public class GcStoryEntry : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x20A AlienText;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x20A Entry;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x20A Title;
        [NMS(Index = 2)]
        /* 0x60 */ public List<GcStoryEntryBranch> BranchedEntries;
        [NMS(Index = 5)]
        /* 0x70 */ public GcAlienRace AlienTextForceRace;
        [NMS(Index = 4)]
        /* 0x74 */ public bool AutoPrefixWithAlienText;
    }
}
