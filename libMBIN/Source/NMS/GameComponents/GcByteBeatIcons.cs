using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5454ADF25E4638D9, NameHash = 0xB0AEFBA1BDCC6569)]
    public class GcByteBeatIcons : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x000 */ public TkTextureResource[] Icons;
        [NMS(Index = 1)]
        /* 0x948 */ public TkTextureResource SawTooth;
        [NMS(Index = 2)]
        /* 0x9CC */ public TkTextureResource Sine;
        [NMS(Index = 3)]
        /* 0xA50 */ public TkTextureResource Square;
        [NMS(Index = 4)]
        /* 0xAD4 */ public TkTextureResource Triangle;
    }
}
