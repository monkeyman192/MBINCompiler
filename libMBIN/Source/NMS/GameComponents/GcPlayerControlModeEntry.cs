using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE0148B70A176962C, NameHash = 0x56203212)]
    public class GcPlayerControlModeEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkModelResource ControlModeResource;
        [NMS(Index = 0)]
        /* 0x18 */ public NMSString0x10 Id;
    }
}
