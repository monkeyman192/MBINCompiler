using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE03B5DCACF43ADC3, NameHash = 0x4A57F915F84ABBCD)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public NMSString0x20A Puzzle;
        /* 0x30 */ public bool ForceMissionSeed;
        /* 0x38 */ public NMSString0x10 AltPriorityMissionForSelection;
    }
}
