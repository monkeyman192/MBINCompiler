using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x55246CB1206CD7A7, NameHash = 0xE9BF52BE754A51E0)]
    public class GcMissionSequenceSignalGalacticPoint : NMSTemplate
    {
        /* 0x00 */ public GcMissionGalacticPoint Target;
        /* 0x04 */ public NMSString0x80 DebugText;
        /* 0x84 */ public NMSString0x80 Message;
    }
}
