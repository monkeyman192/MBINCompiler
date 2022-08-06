using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59E934EAC79B537E, NameHash = 0xD15F5E0AAE5AA74)]
    public class GcMissionSequenceEndScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public NMSString0x80 DebugText;
    }
}
