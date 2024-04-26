namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32669E5C63E0E597, NameHash = 0xDD7598814880C206)]
    public class GcFontTypesEnum : NMSTemplate
    {
        // size: 0x8
        public enum FontEnum : uint {
            Impact,
            Bebas,
            GeosansLightWide,
            GeosansLight,
            GeosansLightMedium,
            GeosansLightSmall,
            Segoeuib,
            Segoeui32,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FontEnum Font;
    }
}
