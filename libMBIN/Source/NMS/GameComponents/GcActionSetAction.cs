using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x63E70C7B31829EF0, NameHash = 0xF69368BA4545C60E)]
    public class GcActionSetAction : NMSTemplate
    {
        public GcActionUseType Status;
        public GcInputActions Action;
    }
}
