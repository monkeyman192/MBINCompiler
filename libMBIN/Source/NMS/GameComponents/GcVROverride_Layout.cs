namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C234564A178CC1C, NameHash = 0xE16B8EC5F09E6041)]
    public class GcVROverride_Layout : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float FloatValue;
        // size: 0x5
        public enum VROverride_LayoutEnum : uint {
            PosX,
            PosY,
            LayerWidth,
            LayerHeight,
            MaxWidth,
        }
        [NMS(Index = 0)]
        /* 0x4 */ public VROverride_LayoutEnum VROverride_Layout;
    }
}
