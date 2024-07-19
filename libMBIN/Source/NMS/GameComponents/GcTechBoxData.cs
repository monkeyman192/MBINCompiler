using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC2E2A8078DC914A, NameHash = 0xAC0BDF9E)]
    public class GcTechBoxData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public TkTextureResource Icon;
        [NMS(Index = 1)]
        /* 0x18 */ public NMSString0x10 InstallTechID;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x10 ProductID;
        [NMS(Index = 3)]
        /* 0x38 */ public bool IsAlien;
    }
}
