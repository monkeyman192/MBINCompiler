using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6F5D124FF129CA16, NameHash = 0x489FC19669F32DA6)]
    public class GcAtlasSendSubmitContribution : NMSTemplate
    {
        /* 0x0 */ public int MissionIndex;
        /* 0x4 */ public int Contribution;
    }
}
