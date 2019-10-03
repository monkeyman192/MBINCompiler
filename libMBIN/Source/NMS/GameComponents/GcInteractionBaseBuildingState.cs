using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x74D72ACAAE69D013, NameHash = 0x914E2AF518E30AB2)]
    public class GcInteractionBaseBuildingState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TriggerAction;
        public int Time;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
