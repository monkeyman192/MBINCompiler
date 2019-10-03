using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x10C3634F7D14FD1D, NameHash = 0x4A57F915F84ABBCD)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Mission;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Puzzle;
    }
}
