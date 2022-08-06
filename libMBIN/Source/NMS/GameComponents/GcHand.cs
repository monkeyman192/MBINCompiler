using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAB044AA8311F68AD, NameHash = 0xDF2E636EA66DCE65)]
    public class GcHand : NMSTemplate
    {
        public enum HandEnum { Right, Left }
        public HandEnum Hand;
    }
}