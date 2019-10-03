using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8A5CC94D0941C3D, NameHash = 0xD550A58E83EA253)]
    public class GcScanEventTable : NMSTemplate
    {
        public List<GcScanEventData> Events;
    }
}
