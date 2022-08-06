using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2514752BC3F1D4DC, NameHash = 0xB0AEFBA1BDCC6569)]
    public class GcByteBeatIcons : NMSTemplate
    {
        [NMS(Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x000 */ public TkTextureResource[] Icons;
        /* 0x948 */ public TkTextureResource SawTooth;
        /* 0x9CC */ public TkTextureResource Sine;
        /* 0xA50 */ public TkTextureResource Square;
        /* 0xAD4 */ public TkTextureResource Triangle;
    }
}
