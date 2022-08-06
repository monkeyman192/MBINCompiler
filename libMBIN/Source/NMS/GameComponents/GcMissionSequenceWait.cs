using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC03B938E799F2CE9, NameHash = 0x47C4BE1F468F66AA)]
    public class GcMissionSequenceWait : NMSTemplate
    {
        /* 0x00 */ public float Time;
        /* 0x04 */ public NMSString0x80 DebugText;
        /* 0x84 */ public bool SuppressMessages;
        /* 0x85 */ public bool MultiplyTimeBySeasonValue;
    }
}
