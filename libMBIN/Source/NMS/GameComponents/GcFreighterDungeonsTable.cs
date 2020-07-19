using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x2D17AE27518A3733, NameHash = 0x556A3DBA7B5C9168)]
    public class GcFreighterDungeonsTable : NMSTemplate
    {
        /* 0x0 */ public List<GcFreighterDungeonParams> Dungeons;
    }
}
