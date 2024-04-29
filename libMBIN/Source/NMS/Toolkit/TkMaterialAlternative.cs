namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2AC9597BDDE2225A, NameHash = 0xB49AE407F95DCEE4)]
    public class TkMaterialAlternative : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A MaterialAlternativeId;
        // size: 0x4
        public enum TextureTypeEnum : uint {
            Diffuse,
            Normal,
            Ambient,
            Environment,
        }
        [NMS(Index = 0)]
        /* 0x20 */ public TextureTypeEnum TextureType;
        [NMS(Index = 1)]
        /* 0x24 */ public NMSString0x80 File;
    }
}
