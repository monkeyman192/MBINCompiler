using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x67831DB54A6008E8, NameHash = 0x15BC2878FF0C535)]
    public class GcMissionSequenceWaitForBuild : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string TargetTech;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
