using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xBA8D3003D0FE5EB9, NameHash = 0x5CA5E4883985A60B)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        public List<GcAISpaceshipModelData> Spaceships;
    }
}