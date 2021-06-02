using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x110, GUID = 0x67831DB54A6008E8, NameHash = 0x15BC2878FF0C535)]
    public class GcMissionSequenceWaitForBuild : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x10 TargetTech;
        /* 0x090 */ public NMSString0x80 DebugText;
    }
}