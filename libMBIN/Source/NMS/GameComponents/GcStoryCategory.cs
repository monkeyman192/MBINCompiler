using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF62A870B64B8CA67, NameHash = 0x276FB03774F36C9F)]
    public class GcStoryCategory : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CategoryID;
        /* 0x020 */ public NMSString0x20A CategoryIDUpper;
        /* 0x040 */ public TkTextureResource IconOn;
        /* 0x0C4 */ public TkTextureResource IconOff;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x148 */ public GcStoryPage[] Pages;
    }
}
