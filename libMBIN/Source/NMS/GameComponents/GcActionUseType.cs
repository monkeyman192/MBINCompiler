using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x512A832CC804C05F, NameHash = 0x498BFDCD029948EF)]
    public class GcActionUseType : NMSTemplate
    {
        public enum ActionUseTypeEnum { Active, ActiveVR, ActiveXbox, ActivePS4, Hidden, Debug, Obsolete }
        public ActionUseTypeEnum ActionUseType;
    }
}