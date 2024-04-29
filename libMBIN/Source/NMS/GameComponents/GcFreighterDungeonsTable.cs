using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD69C97F2823D2E5A, NameHash = 0x556A3DBA7B5C9168)]
    public class GcFreighterDungeonsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterDungeonParams> Dungeons;
    }
}
