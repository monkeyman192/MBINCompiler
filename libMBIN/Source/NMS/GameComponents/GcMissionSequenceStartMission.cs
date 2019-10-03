using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x98, Alignment = 0x8, GUID = 0x53DA614048F0E999, NameHash = 0x5BB6B87A77237F5E)]
    public class GcMissionSequenceStartMission : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string MissionID;
        /* 0x10 */ public bool MakeCurrent;
        /* 0x11 */ public bool Restart;
        /* 0x12 */ public bool Forced;
        [NMS(Size = 0x80)]
        /* 0x13 */ public string DebugText;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x93 */ public byte[] EndPadding;
    }
}
