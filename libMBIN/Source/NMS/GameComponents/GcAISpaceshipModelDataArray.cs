using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A8EE417AED56DD6, NameHash = 0x5CA5E4883985A60B)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcAISpaceshipModelData> Spaceships;
    }
}
