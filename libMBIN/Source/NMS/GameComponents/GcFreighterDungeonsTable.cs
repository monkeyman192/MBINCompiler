using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x64B04F1B6ACB84E3, NameHash = 0x556A3DBA7B5C9168)]
    public class GcFreighterDungeonsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterDungeonParams> Dungeons;
    }
}
