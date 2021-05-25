using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x33D4A6F29AFA50E4, NameHash = 0xE2DF0C2D3E6E3BF8)]
    public class GcMissionConsequenceRemoveCommunicatorMessage : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Comms;
    }
}