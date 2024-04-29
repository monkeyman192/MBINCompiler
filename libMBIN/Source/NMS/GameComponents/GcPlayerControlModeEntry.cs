using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D428F7DCB10CD81, NameHash = 0xB40BD8EC092ACF02)]
    public class GcPlayerControlModeEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public TkModelResource ControlModeResource;
    }
}
