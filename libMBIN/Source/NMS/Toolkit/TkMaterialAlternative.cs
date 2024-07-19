namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x28CF6BA9086D4A7A, NameHash = 0xFC096DCB)]
    public class TkMaterialAlternative : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MaterialAlternativeId;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString File;
        // size: 0x4
        public enum TextureTypeEnum : uint {
            Diffuse,
            Normal,
            Ambient,
            Environment,
        }
        [NMS(Index = 0)]
        /* 0x30 */ public TextureTypeEnum TextureType;
    }
}
