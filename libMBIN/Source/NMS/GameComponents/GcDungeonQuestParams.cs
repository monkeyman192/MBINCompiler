using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2F2B3D5F3475DF, NameHash = 0xE0DB85FF)]
    public class GcDungeonQuestParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> QuestItems;
        [NMS(Index = 0)]
        /* 0x10 */ public float Probability;
    }
}
