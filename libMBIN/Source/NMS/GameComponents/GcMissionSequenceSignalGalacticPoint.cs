using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x104, GUID = 0xD77B64DA9352885D, NameHash = 0xE9BF52BE754A51E0)]
    public class GcMissionSequenceSignalGalacticPoint : NMSTemplate     // size: 0x104
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public GcMissionGalacticPoint Target;
        /* 0x084 */ public NMSString0x80 DebugText;
    }
}