using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD016B8C23D28332A, NameHash = 0x3839C255F197D92C)]
    public class GcTechBoxData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 InstallTechID;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ProductID;
        [NMS(Index = 2)]
        /* 0x20 */ public TkTextureResource Icon;
        [NMS(Index = 3)]
        /* 0xA4 */ public bool IsAlien;
    }
}
