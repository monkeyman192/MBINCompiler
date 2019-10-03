using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6B9AF43F59587621, NameHash = 0xE2DF0C2D3E6E3BF8)]
    public class GcMissionConsequenceRemoveCommunicatorMessage : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Comms;
    }
}
