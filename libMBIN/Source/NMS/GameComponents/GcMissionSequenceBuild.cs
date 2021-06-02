using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x138, Alignment = 0x8, GUID = 0x437FC5DF9956B5FD, NameHash = 0xB9769DB00B6A3E69)]
    public class GcMissionSequenceBuild : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 Part;
        /* 0x090 */ public bool TeachIfNotKnown;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x091 */ public byte[] Padding91;
        /* 0x098 */ public GcBuildingPartSearchType Type;
        /* 0x0B8 */ public NMSString0x80 DebugText;
    }
}
