using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x924CF80466FFBE44, NameHash = 0x14E2334CC95303F7)]
    public class GcAtlasSendSubmitContributionActual : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int MissionIndex;
        /* 0x14 */ public int Contribution;
    }
}
