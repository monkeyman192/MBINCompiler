using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF54F66C4367F1536, NameHash = 0x785DA5C6069D4C12)]
    public class GcMissionSequenceGetUnits : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
