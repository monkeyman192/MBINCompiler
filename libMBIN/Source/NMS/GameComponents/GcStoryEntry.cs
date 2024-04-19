using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9741357F5A74C1C, NameHash = 0x7D4184057E24E50A)]
    public class GcStoryEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A AlienText;
        /* 0x20 */ public NMSString0x20A Entry;
        /* 0x40 */ public NMSString0x20A Title;
        /* 0x60 */ public List<GcStoryEntryBranch> BranchedEntries;
        /* 0x70 */ public GcAlienRace AlienTextForceRace;
        /* 0x74 */ public bool AutoPrefixWithAlienText;
    }
}
