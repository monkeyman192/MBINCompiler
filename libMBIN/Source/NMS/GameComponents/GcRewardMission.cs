using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, Alignment = 0x8, GUID = 0xEFFE811FCD5015A6, NameHash = 0xFCFEF60947A44802)]
    public class GcRewardMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public bool SetAsSelected;
        /* 0x11 */ public bool FailRewardIfMissionActive;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] EndPadding;
    }
}
