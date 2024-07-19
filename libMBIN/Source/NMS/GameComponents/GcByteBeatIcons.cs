using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AD6B1DC17FBB91D, NameHash = 0xDF9574EF)]
    public class GcByteBeatIcons : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x000 */ public TkTextureResource[] Icons;
        [NMS(Index = 1)]
        /* 0x1B0 */ public TkTextureResource SawTooth;
        [NMS(Index = 2)]
        /* 0x1C8 */ public TkTextureResource Sine;
        [NMS(Index = 3)]
        /* 0x1E0 */ public TkTextureResource Square;
        [NMS(Index = 4)]
        /* 0x1F8 */ public TkTextureResource Triangle;
    }
}
