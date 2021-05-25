using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, Alignment = 0x8, GUID = 0xA3B5E6806301CC0C, NameHash = 0x48508806BFEC4731)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string MissionID;
        /* 0x10 */ public bool Silent;
        [NMS(Size = 0x80)]
        /* 0x11 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x91 */ public byte[] EndPadding;
    }
}