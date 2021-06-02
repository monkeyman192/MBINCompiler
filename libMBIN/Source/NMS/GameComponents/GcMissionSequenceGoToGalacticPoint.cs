using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0x4D166CB02862AD83, NameHash = 0xDC7A747D3350B89B)]
    public class GcMissionSequenceGoToGalacticPoint : NMSTemplate      // size: 0x104
    {
        /* 0x000 */ public NMSString0x80 MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public GcMissionGalacticPoint Target;
        /* 0x084 */ public NMSString0x80 DebugText;
    }
}