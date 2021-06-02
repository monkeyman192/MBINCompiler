using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x1EF9465CBAFBBA3F, NameHash = 0x2229006A022A6430)]
    public class GcBaseBuildingEntryCosts : NMSTemplate
    {
        public NMSString0x10 ID;
        public float Active0AverageFrameTimeCost;
        public float Active1AverageFrameTimeCost;
        public int ActiveTotalNodes;
        public int ActivePhysicsComponents;
        public float Inactive0AverageFrameTimeCost;
        public float Inactive1AverageFrameTimeCost;
        public int InactiveTotalNodes;
        public int InactivePhysicsComponents;
    }
}
