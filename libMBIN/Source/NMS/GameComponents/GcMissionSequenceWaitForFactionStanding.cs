using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0x29F034D475D98285, NameHash = 0x10BF10453E33157C)]
    public class GcMissionSequenceWaitForFactionStanding : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcFactionSelectOptions SelectFrom;
        /* 0x088 */ public int AmountMin;
        /* 0x08C */ public int AmountMax;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
