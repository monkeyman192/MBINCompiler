using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x8260892F03FDBFC0, NameHash = 0x66D8F2741332E444)]
    public class GcMissionConsequenceRemoveScanEvent : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Event;
    }
}
