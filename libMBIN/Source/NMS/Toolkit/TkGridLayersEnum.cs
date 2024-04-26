namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB9F17954D3E62F66, NameHash = 0xFEF6F10412C7B60)]
    public class TkGridLayersEnum : NMSTemplate
    {
        // size: 0x9
        public enum GridLayerTypesEnum : uint {
            Small,
            Large,
            Resources_Heridium,
            Resources_Iridium,
            Resources_Copper,
            Resources_Nickel,
            Resources_Aluminium,
            Resources_Gold,
            Resources_Emeril,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GridLayerTypesEnum GridLayerTypes;
    }
}
