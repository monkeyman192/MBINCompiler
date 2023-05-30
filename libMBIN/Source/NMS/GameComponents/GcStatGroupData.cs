using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcStatGroupData : NMSTemplate
    {
        public NMSString0x10 GroupName;
        public List<NMSString0x10> TrackedStats;
    }
}
