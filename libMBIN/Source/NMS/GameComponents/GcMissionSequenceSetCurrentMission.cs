using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, Alignment = 0x8, GUID = 0xA3B5E6806301CC0C, NameHash = 0x48508806BFEC4731)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public NMSString0x80 DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x91 */ public byte[] EndPadding;
    }
}