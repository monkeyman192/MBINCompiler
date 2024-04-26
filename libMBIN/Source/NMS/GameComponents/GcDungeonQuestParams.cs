using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DEA97C7B2C9C11C, NameHash = 0xCE00C5120C432BB0)]
    public class GcDungeonQuestParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> QuestItems;
        [NMS(Index = 0)]
        /* 0x10 */ public float Probability;
    }
}
