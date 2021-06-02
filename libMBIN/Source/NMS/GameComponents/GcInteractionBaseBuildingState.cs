using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x74D72ACAAE69D013, NameHash = 0x914E2AF518E30AB2)]
    public class GcInteractionBaseBuildingState : NMSTemplate
    {
        public NMSString0x10 TriggerAction;
        public int Time;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}