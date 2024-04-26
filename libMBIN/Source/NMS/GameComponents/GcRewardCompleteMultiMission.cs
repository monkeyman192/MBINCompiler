using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6463D52AE332EF8E, NameHash = 0xEF104FBE8AD4EB68)]
    public class GcRewardCompleteMultiMission : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> Missions;
    }
}
