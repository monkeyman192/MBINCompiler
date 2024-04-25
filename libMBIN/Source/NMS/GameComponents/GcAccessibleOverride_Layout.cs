namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9F357DA4F413F0D, NameHash = 0xCB6432BD8E0191A0)]
    public class GcAccessibleOverride_Layout : NMSTemplate
    {
        // size: 0x5
        public enum AccessibleOverride_LayoutEnum : uint {
            PosX,
            PosY,
            LayerWidth,
            LayerHeight,
            MaxWidth,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public AccessibleOverride_LayoutEnum AccessibleOverride_Layout;
        [NMS(Index = 1)]
        /* 0x4 */ public float FloatValue;
    }
}
