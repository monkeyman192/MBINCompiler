using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79972371778E4C36, NameHash = 0xD9BAAE731EB23B1)]
    public class GcMissionSequenceVehicleScan : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x20A ScanEventID;
        /* 0xA0 */ public NMSString0x80 DebugText;
    }
}
